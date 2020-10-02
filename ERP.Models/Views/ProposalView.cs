using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;


namespace ERP.Models.Views
{
    public class ProposalView
    {
        public ProposalView()
        {
            Partner = new BusinessPartner();
            IsCompany = true;
            Contact = new BusinessPartnerContact();
        }
        public bool IsCompany { get; set; }
        public bool CreateNew { get; set; }
        public IEnumerable<SelectListItem> Companies { get; set; }
        public IEnumerable<SelectListItem> Persons { get; set; }
        public IEnumerable<BusinessPartner> BusinessPartners { get; set; }
        public IEnumerable<BusinessPartner> CompaniesBP { get; set; }
        public IEnumerable<BusinessPartner> PersonsBP { get; set; }
        public BusinessPartner Partner { get; set; }
        public int SelectedCompanyId { get; set; }
        public int SelectedPersonId { get; set; }
        public int SelectedContactId { get; set; }
        public string PersonName { get; set; }
        public string Description { get; set; }
        public ProposalContactTypes ContactMode { get; set; }
        public BusinessPartnerContact Contact { get; set; }
        public List<ProposalItems> Items { get; set; }
        public string InvoiceItems { get; set; }
        public decimal? Discount { get; set; }
        public int QuoteRevisionNo { get; set; }
        public byte VAT { get; set; }
    }

    public class ProposalVM
    {
        public bool IsCompany { get; set; }
        public bool CreateNew { get; set; }
        public BusinessPartner Partner { get; set; }
        public int? SelectedCompanyId { get; set; }
        public int? SelectedPersonId { get; set; }
        public string PersonName { get; set; }
        public string Description { get; set; }
        public ProposalContactTypes ContactMode { get; set; }
        public int? SelectedContactId { get; set; }
        public BusinessPartnerContact NewContact { get; set; }
        public decimal? Discount { get; set; }
        public List<ProposalItems> Items { get; set; }
        public int QuoteRevisionNo { get; set; }
        public byte VAT { get; set; }
    }
    public class ProposalViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Timestamp { get; set; }
        public ProposalContactTypes ContactMode { get; set; }
        public int? WorkOrderId { get; set; }
        public int? BusinessPartnerId { get; set; }
        public int? BusinessPartnerContactId { get; set; }

        public string Name { get; set; }

        public string PointofContact { get; set; }

        public string MobileNo { get; set; }

        public string EmailId { get; set; }

        public string Address { get; set; }

        public int BusinessPartnerTypeId { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public decimal? Discount { get; set; }
        public int QuoteRevisionNo { get; set; }
        public byte VAT { get; set; }
    }

    public class ProposalItemsUpdateModel
    {
        public List<ProposalItems> Items { get; set; }
        public List<ProposalItems> DeletedItems { get; set; }
        public decimal? Discount { get; set; }
        public decimal VAT { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
