using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ERP.Models;
using ERP.Models.Views;
using ERP.Web.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ERP.Web.Controllers
{
    [Authorize]
    public class SuppliersController : Controller
    {
        private readonly IAPIHelper api;

        // static HttpClient client = new HttpClient();

        public SuppliersController(IAPIHelper helper)
        {
            this.api=helper;
        }

        public async Task<IActionResult> List(){
            var suppliers=await api.Get<IEnumerable<SuppliersView>>("suppliers");
            return View(suppliers);
        }

        public async Task<IActionResult> GetSuppliersDropdown()
        {
            var suppliersList = await api.Get<IEnumerable<SelectListItem>>("Suppliers/GetDropDown");
            return Json(suppliersList.ToList());
        }

        public IActionResult Create()
        {
            var model=new Suppliers();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Suppliers model)
        {
            if(!ModelState.IsValid)return View(model);

            try
            {
                var apiModel = new APIEmpIdModel<Suppliers>();
                apiModel.EmployeeId = int.Parse(User.Claims.Single(c => c.Type == "userid").Value);
                apiModel.Model = model;
                var supplierId = await api.Post<APIEmpIdModel<Suppliers>, int>("suppliers/", apiModel);

                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                ViewBag.Error = $"Error: <br />Message: {ex.Message}<br />Inner Exception: {ex.InnerException}";
                return View(model);
            }
        }
    }
        


    
}
            