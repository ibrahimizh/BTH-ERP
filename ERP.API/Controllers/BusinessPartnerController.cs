using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP.API.Data.Services;
using ERP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessPartnerController : Controller
    {
        private BusinessPartnerService db;

        public BusinessPartnerController(BusinessPartnerService service)
        {
            this.db = service;
        }
        [HttpGet("GetDropDown")]
        public ActionResult<IEnumerable<SelectListItem>> GetDropDown()
        {
            var customers = db.GetDropDown().ToList();
            return customers;
        }
        [HttpGet("Index")]
        public ActionResult<IEnumerable<BusinessPartner>> Index()
        {
            try
            {
                var businessPartners = db.List();
                return businessPartners.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet("GetBusinessPartner/{id}")]
        public ActionResult<BusinessPartner> GetBusinessPartner(int id)
        {
            try
            {
                var businessPartner = db.GetBusinessPartner(id);
                return businessPartner;
            }
            catch (Exception)
            {

                throw;
            }

        }
        [HttpGet("GetBusinessPartnerById/{id}")]
        public ActionResult<BusinessPartnerViewModel> GetBusinessPartnerById(int id)
        {
            try
            {
                var businessPartner = db.GetBusinessPartnerById(id);
                businessPartner.Contacts = db.GetContactsByBusinessPartnerId(id).ToList();
                return businessPartner;
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpGet("GetBusinessPartnerByName/{name}")]
        public ActionResult<BusinessPartnerViewModel> GetBusinessPartnerByName(string name)
        {
            try
            {
                var businessPartner = db.GetBusinessPartnerByName(name);
                if (businessPartner != null)
                {
                    businessPartner.Contacts = db.GetContactsByBusinessPartnerId(businessPartner.Id).ToList();
                }
                return businessPartner;
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpGet("GetPartnersByBusinessPartnerId/{id}")]
        public ActionResult<IEnumerable<BusinessPartnerContact>> GetPartnersByBusinessPartnerId(int id)
        {
            try
            {
                var contacts = db.GetContactsByBusinessPartnerId(id);
                return contacts.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet("GetAllCompanies")]
        public ActionResult<IEnumerable<BusinessPartner>> GetAllCompanies()
        {
            try
            {
                var companies = db.GetCompanies();
                return companies.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost("Update")]
        public ActionResult<bool> Update([FromBody] BusinessPartner value)
        {
            try
            {
                db.UpdateCompany(value);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}