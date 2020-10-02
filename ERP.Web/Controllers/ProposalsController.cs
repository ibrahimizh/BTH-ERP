using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ERP.Models;
using ERP.Models.Views;
using ERP.Web.Helpers;
using ERP.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace ERP.Web.Controllers
{

    

    [Authorize]
    public class ProposalsController:Controller
    {
        private DateTime July01_2020 = DateTime.ParseExact("01/07/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture);
        private IAPIHelper api;

        public ProposalsController(IAPIHelper helper)
        {
            this.api=helper;
        }

        public async Task<IActionResult> List(){
            var proposals=await api.Get<IEnumerable<ProposalViewModel>>("Proposals/GetProposals");
            return View(proposals);
        }

        public async Task<IActionResult> List2()
        {
            var proposals = await api.Get<IEnumerable<ProposalViewModel>>("Proposals/GetProposals");
            return View(proposals);
        }

        public async Task<IActionResult> Details(int id)
        {
            var proposal=await api.Get<ProposalViewModel>($"Proposals/GetProposalById/{id}");
            return PartialView("_Details",proposal);
        }
        public async Task<IActionResult> Details2(int id)
        {
            var proposal = await api.Get<ProposalViewModel>($"Proposals/GetProposalById/{id}");
            return View("Details2", proposal);
        }

        public async Task<IActionResult> Create(){
            try
            {
                var proposal = new ProposalView();
                proposal.BusinessPartners = await api.Get<IEnumerable<BusinessPartner>>("BusinessPartner/Index");
                proposal.Companies = proposal.BusinessPartners.Where(bp => bp.BusinessPartnerTypeId.Equals(2)).Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                }).ToList();
                proposal.Persons = proposal.BusinessPartners.Where(bp => bp.BusinessPartnerTypeId.Equals(3)).Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                }).ToList();
                ViewBag.BusinessPartners = JsonConvert.SerializeObject(proposal.BusinessPartners,Formatting.Indented);
                
                ViewBag.VAT = (DateTime.Today < July01_2020) ? 5 : 15;
                return View(proposal);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProposalView model)
        {
            ViewBag.Success = "";
            ViewBag.Error = "";
            var errors = new List<string>();
            if (model.InvoiceItems == null || model.InvoiceItems.Count()==0) errors.Add("Add atleast one Item !");
            
            //if(!ModelState.IsValid)return View(model);
            
            if (model.CreateNew)
            {
                if (model.IsCompany)
                {
                    if (string.IsNullOrEmpty(model.Partner.Name)) errors.Add("Enter Company Name !");
                }
                else
                {
                    model.Partner.Name = model.PersonName;
                    if (string.IsNullOrEmpty(model.PersonName)) errors.Add("Enter Person Name !");
                }
                if(string.IsNullOrEmpty(model.Partner.EmailId)&& string.IsNullOrEmpty(model.Partner.MobileNo)) errors.Add("Enter Phone Number or Email !");
            }
            else
            {
                if (model.IsCompany)
                {
                    if (model.SelectedCompanyId==0) errors.Add("Select Company !");
                }
                else
                {
                    if (model.SelectedPersonId == 0) errors.Add("Select Person !");
                }
            }
            
            //if (string.IsNullOrEmpty(model.Description)) errors.Add("Enter Description !");
            if (errors.Count > 0)
            {
                var errorMessage = "";
                errors.ForEach(err => errorMessage += err + "<br />");
                ViewBag.Error = errorMessage;
                return View(model);
            }
            else
            {
                model.Items = JsonConvert.DeserializeObject<List<ProposalItems>>(model.InvoiceItems);
                //if (model.Partner == null) model.Partner = new BusinessPartner();
                if (model.SelectedCompanyId > 0 || model.SelectedPersonId > 0) model.Partner = new BusinessPartner() {
                    Name="Name"
                };

                //if (string.IsNullOrEmpty(model.PersonName)) model.PersonName = "";
                if (string.IsNullOrEmpty(model.Contact.Name)) model.Contact.Name = "Name";
                var newProposalVM = new ProposalVM()
                {
                    ContactMode=model.ContactMode,
                    CreateNew=model.CreateNew,
                    Description=model.Description,
                    IsCompany=model.IsCompany,
                    Partner=model.Partner,
                    PersonName=model.PersonName,
                    SelectedCompanyId=model.SelectedCompanyId,
                    SelectedPersonId=model.SelectedPersonId,
                    SelectedContactId=model.SelectedContactId,
                    NewContact=model.Contact,
                    Items=model.Items,
                    Discount=model.Discount,
                    VAT=(DateTime.Today<July01_2020)?(byte)5:(byte)15
                };

                var apiModel = new APIEmpIdModel<ProposalVM>();
                apiModel.EmployeeId = int.Parse(User.Claims.Single(c => c.Type == "userid").Value);
                apiModel.Model = newProposalVM;
                var result = await api.Post<APIEmpIdModel<ProposalVM>, int>("Proposals/", apiModel);
                if (result > 0)
                {
                    //ViewBag.Success = "Proposal Saved";
                    //ModelState.Clear();
                    //return View(new Proposal());
                    return RedirectToAction("List2");
                }
                else
                {
                    ViewBag.Error = "Error saving Proposal";
                    return View(model);
                }
            }
        }

        public async Task<JsonResult> GetBusinessPartnerById(int id)
        {
            var businessPartner = await api.Get<BusinessPartnerViewModel>($"BusinessPartner/GetBusinessPartnerById/{id}");
            return Json(businessPartner);
        }
        public async Task<JsonResult> GetBusinessPartnerByName(string name)
        {
            var businessPartner = await api.Get<BusinessPartnerViewModel>($"BusinessPartner/GetBusinessPartnerByName/{name}");
            return Json(businessPartner);
        }
        public async Task<IActionResult> GetQuote(int id)
        {
            try
            {
                var quote = await api.Get<QuoteView>($"Proposals/GetQuote/{id}");
                return Json(quote);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateQuote([FromBody]ProposalItemsUpdateModel model)
        {
            try
            {
                var apiModel = new APIEmpIdModel<ProposalItemsUpdateModel>();
                apiModel.EmployeeId = int.Parse(User.Claims.Single(c => c.Type == "userid").Value);
                apiModel.Model = model;
                var result = await api.Post<APIEmpIdModel<ProposalItemsUpdateModel>, int>("Proposals/UpdateQuote", apiModel);
                return Json(result);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public async Task<IActionResult> GetEvents(int id)
        {
            try
            {
                var events = await api.Get<IEnumerable<ERPeventView>>($"ERPevents/GetEnquiryEvents/{id}");
                return Json(events);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}