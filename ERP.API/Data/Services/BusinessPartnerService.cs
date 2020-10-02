using ERP.API.Data.Queries;
using ERP.Models;
using ERP.Models.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.API.Data.Services
{
    public class BusinessPartnerService
    {
        private IDbContext dbContext;

        public BusinessPartnerService(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IEnumerable<BusinessPartner> List()
        {
            var query = BusinessPartnerQueries.SelectAll;
            return dbContext.GetList<BusinessPartner>(query);
        }
        public BusinessPartner GetBusinessPartner(int id)
        {
            var query = BusinessPartnerQueries.SelectById;
            var parameters = DataHelper.ExtractParameters(new { Id = id });
            return dbContext.Get<BusinessPartner>(query, parameters);
        }
        public BusinessPartnerViewModel GetBusinessPartnerById(int id)
        {
            var query = BusinessPartnerQueries.SelectById;
            var parameters = DataHelper.ExtractParameters(new { Id = id });
            return dbContext.Get<BusinessPartnerViewModel>(query, parameters);
        }
        public BusinessPartnerViewModel GetBusinessPartnerByName(string name)
        {
            var query = BusinessPartnerQueries.SelectByName;
            var parameters = DataHelper.ExtractParameters(new { Name = name });
            var businessPartner = dbContext.GetList<BusinessPartnerViewModel>(query, parameters);
            return businessPartner.FirstOrDefault();
        }
        public int Add(BusinessPartner newPartner)
        {
            var query = BusinessPartnerQueries.Insert;
            var parameters = DataHelper.ExtractParameters(newPartner);
            return dbContext.Execute<int>(query, parameters);
        }
        public int AddContact(BusinessPartnerContact newContact)
        {
            var query = BusinessPartnerQueries.InsertContact;
            var parameters = DataHelper.ExtractParameters(newContact);
            return dbContext.Execute<int>(query, parameters);
        }
        public IEnumerable<BusinessPartnerContact> GetContactsByBusinessPartnerId(int businessPartnerId)
        {
            var query = BusinessPartnerQueries.SelectAllContactsByBusinessPartnerId;
            var parameters = DataHelper.ExtractParameters(new { BusinessPartnerId = businessPartnerId });
            return dbContext.GetList<BusinessPartnerContact>(query, parameters);
        }
        public IEnumerable<BusinessPartner> GetCompanies()
        {
            var query = BusinessPartnerQueries.SelectAllCompanies;
            var parameters = DataHelper.ExtractParameters(new { BusinessPartnerTypeId = BusinessPartnerTypeName.Company });
            return dbContext.GetList<BusinessPartner>(query, parameters);
        }
        public IEnumerable<SelectListItem> GetDropDown()
        {
            var query = "select * from business_partners;";
            var customersList = dbContext.GetList<BusinessPartner>(query).ToList();
            return customersList.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString()
            }).ToList();
        }
        public void UpdateCompany(BusinessPartner businessPartner)
        {
            var query = BusinessPartnerQueries.Update;
            var parameters = DataHelper.ExtractParameters(businessPartner);
            dbContext.ExecuteNonQuery(query, parameters);
        }
    }
}
