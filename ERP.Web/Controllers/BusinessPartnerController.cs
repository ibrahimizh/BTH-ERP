using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP.Models;
using ERP.Web.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ERP.Web.Controllers
{
    
    [Authorize]
    public class BusinessPartnerController : Controller
    {
        private IAPIHelper api;

        public BusinessPartnerController(IAPIHelper helper)
        {
            this.api = helper;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> GetCustomersDropdown()
        {
            var customersList = await api.Get<IEnumerable<SelectListItem>>("BusinessPartner/GetDropDown");
            return Json(customersList.ToList());
        }
        public async Task<IActionResult> Companies()
        {
            var workOrders = await api.Get<IEnumerable<BusinessPartner>>("BusinessPartner/GetAllCompanies");
            return View(workOrders);
        }

        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Update([FromBody]BusinessPartner model)
        {
            var result=await api.Post<BusinessPartner,bool>("BusinessPartner/Update", model);
            return Json(true);
        }

    }
    public class BusinessPartnerVM : BusinessPartner
    {

    }
}