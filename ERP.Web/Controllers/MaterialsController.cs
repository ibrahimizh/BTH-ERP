using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ERP.Models;
using ERP.Web.Helpers;
using ERP.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using ERP.Models.Views;

namespace ERP.Web.Controllers
{
    [Authorize]
    public class MaterialsController : Controller
    {
        // static HttpClient client = new HttpClient();  
        // private readonly IOptions<ConfigurationSettings> configuration;      
        private IAPIHelper api;

        // public MaterialsController(IOptions<ConfigurationSettings> config,IAPIHelper helper)
        // {
        //     this.api=helper;
        //     configuration=config;
        // }

        public MaterialsController(IAPIHelper helper)
        {
            this.api=helper;
        }

        public async Task<IActionResult> List(){
            try
            {
                var materials = await api.Get<IEnumerable<MaterialsView>>("materials");
                return View(materials);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<IActionResult> GetMaterialsDropdown(){
            var materialsList=await api.Get<IEnumerable<Materials>>("materials");
            
            var materialsDropdown=materialsList.Select(m=>new SelectListItem{
                Text=m.Name,
                Value=m.Id.ToString()
            }).ToList();
            
            return Json(materialsDropdown);
        }
        public IActionResult Create()
        {
            //var claim = User.Claims.Single(c => c.Type == "role").Value;
            //if (claim== "admin")
            //{
            //    var model = new Materials();
            //    return View(model);
            //}
            //else return View("NoAccess");

            var model = new Materials();            
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Materials model)
        {
            try
            {
                if (!ModelState.IsValid) return View(model);

                var isMaterialCodeDuplicated=await api.Get<Materials>($"materials/getbycode/{model.Code}");
                if(isMaterialCodeDuplicated!=null)
                {
                        //Code Duplicated
                        ModelState.AddModelError("Code", "Code already exist!");
                        return View(model);
                }
                var apiModel = new APIEmpIdModel<Materials>();
                apiModel.EmployeeId = int.Parse(User.Claims.Single(c => c.Type == "userid").Value);
                apiModel.Model = model;
                var materialId=await api.Post<APIEmpIdModel<Materials>,int>("materials/",apiModel);
                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                ViewBag.Error = $"Error: <br />Message: {ex.Message}<br />Inner Exception: {ex.InnerException}";
                return View(model);
            }
        }
        public async Task<IActionResult> List2()
        {
            try
            {
                var materials = await api.Get<IEnumerable<Materials>>("materials");
                return View(materials);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<IActionResult> Update(int id)
        {
            var model = await api.Get<Materials>($"materials/getbyid/{id}");
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Materials model)
        {
            try
            {
                if (!ModelState.IsValid) return View(model);
                var keyValue = new KeyValue() { Key = model.Id, Value = model.Code };
                var isMaterialCodeDuplicated = await api.Post<KeyValue, bool>($"materials/CodeDuplicationCheckForUpdate/",keyValue );
                if (!isMaterialCodeDuplicated)
                {
                    //Code Duplicated
                    ModelState.AddModelError("Code", "Code already exist!");
                    return View(model);
                }
                var result = await api.Post<Materials, bool>("materials/update", model);
                return RedirectToAction("List2");
            }
            catch (Exception ex)
            {
                ViewBag.Error = $"Error: <br />Message: {ex.Message}<br />Inner Exception: {ex.InnerException}";
                return View(model);
            }
        }
    }
        


    
}
            