using System;
using ERP.Models;
using ERP.API.Data.Queries;
using System.Collections.Generic;
using ERP.Models.Views;
using ERP.Models.Enums;
using System.Linq;

namespace ERP.API.Data.Services
{
    public class ProposalService
    {
        private IDbContext dbContext;

        public ProposalService(IDbContext dbContext)
        {
            this.dbContext=dbContext;
        }

        public int InsertProposal(APIEmpIdModel<ProposalVM> model){
            try
            {
                var businessPartnerId = 0;
                var contactId = (model.Model.SelectedContactId==0)?null: model.Model.SelectedContactId;
                var bpService = new BusinessPartnerService(dbContext);
                if (model.Model.CreateNew)
                {
                    
                    var bp = new BusinessPartner();
                    bp.Address = model.Model.Partner.Address;
                    bp.EmailId = model.Model.Partner.EmailId;
                    bp.MobileNo = model.Model.Partner.MobileNo;
                    bp.VATNo = model.Model.Partner.VATNo;
                    if (model.Model.IsCompany)
                    {
                        bp.Name = model.Model.Partner.Name;
                        //bp.PointofContact = model.Model.Partner.PointofContact;
                        bp.BusinessPartnerTypeId = (int)BusinessPartnerTypeName.Company;
                    }
                    else
                    {
                        bp.Name = model.Model.PersonName;
                        bp.BusinessPartnerTypeId = (int)BusinessPartnerTypeName.Individual;
                    }
                    businessPartnerId = bpService.Add(bp);
                    
                }
                else
                {
                    if (model.Model.IsCompany)
                    {
                        businessPartnerId = model.Model.SelectedCompanyId.Value;
                    }
                    else
                    {
                        businessPartnerId = model.Model.SelectedPersonId.Value;
                    }
                }

                if (!contactId.HasValue && model.Model.NewContact.Id == 0 && model.Model.NewContact.Name!="Name")
                {
                    var contact = new BusinessPartnerContact();
                    contact.BusinessPartnerId = businessPartnerId;
                    contact.ContactNo = model.Model.NewContact.ContactNo;
                    contact.Email = model.Model.NewContact.Email;
                    contact.Name = model.Model.NewContact.Name;
                    contactId = bpService.AddContact(contact);
                }

                var proposal = new Proposal()
                {
                    BusinessPartnerId = businessPartnerId,
                    ContactMode = model.Model.ContactMode,
                    Description = model.Model.Description,
                    BusinessPartnerContactId=contactId,
                    Discount=(model.Model.Discount.HasValue)? model.Model.Discount.Value:0,
                    VAT=model.Model.VAT
                };
                var queryAddProposal = ProposalQueries.AddProposal;
                var parametersAddProposal = DataHelper.ExtractParameters(proposal);
                var proposalId = dbContext.Get<int>(queryAddProposal, parametersAddProposal);
                model.Model.Items.ForEach(p => p.ProposalId = proposalId);
                var queries = new List<QueryWithParameters>();

                var queryAddProposalItem = ProposalQueries.AddProposalItem;
                foreach(var item in model.Model.Items)
                {

                    var parametersAddProposalItem = DataHelper.ExtractParameters(item);
                    queries.Add(new QueryWithParameters()
                    {
                        Query = queryAddProposalItem,
                        Parameters = parametersAddProposalItem
                    });
                }

                //Add Event
                var erpEvent = new ERPEventHelper().GetEventModel(model.EmployeeId, proposalId, EventTypes.EnquiryCreate);
                queries.Add(new QueryWithParameters()
                {
                    Query = EventQueries.EventInsert,
                    Parameters = DataHelper.ExtractParameters(erpEvent)
                });

                dbContext.ExecuteTransaction(queries);
                return 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateProposalItems(APIEmpIdModel<ProposalItemsUpdateModel> model)
        {
            var queries = new List<QueryWithParameters>();
            var queryUpdateProposalItem = ProposalQueries.UpdateProposalItems;
            var proposalId = model.Model.Items.FirstOrDefault().ProposalId;
            foreach (var item in model.Model.Items)
            {
                if(item.Id==0) dbContext.ExecuteNonQuery(ProposalQueries.AddProposalItem, DataHelper.ExtractParameters(item));
                else dbContext.ExecuteNonQuery(queryUpdateProposalItem, DataHelper.ExtractParameters(item));
            }
            foreach(var item in model.Model.DeletedItems)
            {
                dbContext.ExecuteNonQuery(ProposalQueries.DeleteProposalItem, DataHelper.ExtractParameters(item));
            }

            var updateQuery = ProposalQueries.UpdateQuote;
            var updateParams= DataHelper.ExtractParameters(new { TotalAmount = model.Model.TotalAmount,Discount=model.Model.Discount, ProposalId=proposalId });
            dbContext.ExecuteNonQuery(updateQuery, updateParams);

            var erpEvent = new ERPEventHelper().GetEventModel(model.EmployeeId, proposalId, EventTypes.QuoteUpdate);
            dbContext.ExecuteNonQuery(EventQueries.EventInsert, DataHelper.ExtractParameters(erpEvent));

            return dbContext.Get<int>(ProposalQueries.GetQuoteRevisionNo, DataHelper.ExtractParameters(new { ProposalId = proposalId }));
        }
        public IEnumerable<ProposalViewModel> GetProposals(){
            var query=ProposalQueries.GetAllProposals;
            return dbContext.GetList<ProposalViewModel>(query);
        }

        public ProposalViewModel GetProposalById(int id)
        {
            var query=ProposalQueries.GetProposalById;
            var parameters=DataHelper.ExtractParameters(new{Id=id});
            return dbContext.Get<ProposalViewModel>(query,parameters);
        }

        public QuoteView GetQuote(int proposalId)
        {
            var quote = new QuoteView();
            var query = ProposalQueries.GetQuoteItems;
            var parameters = DataHelper.ExtractParameters(new { ProposalId = proposalId });
            var quoteItems = dbContext.GetList<ProposalItemView>(query, parameters);
            quote.Items = quoteItems;
            if (quote.Items.Count() > 0)
            {
                quote.SubTotal = quote.Items.ToList().Sum(t => t.LineTotal);
                quote.Discount = quote.Items.First().Discount;
                //invoice.VAT = ((invoice.SubTotal - invoice.Discount) * 5) / 100;
                //invoice.Total = (invoice.SubTotal- invoice.Discount) + invoice.VAT;
                quote.VAT = (quote.SubTotal * quote.Items.First().VAT) / 100;
                quote.Total = (quote.SubTotal + quote.VAT) - quote.Discount;
            }
            return quote;
        }


        // public bool Confirm(int id)
        // {

        // }
    }
}