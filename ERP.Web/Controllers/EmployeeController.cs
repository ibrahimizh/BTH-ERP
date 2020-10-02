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
    public class EmployeeController : Controller
    {
        static HttpClient client = new HttpClient();
        private IAPIHelper api;

        public EmployeeController(IAPIHelper helper)
        {
            this.api=helper;
        }

        public async Task<IActionResult> List(){
            var employees=await api.Get<IEnumerable<Employee>>("employee");
            return View(employees);
        }
        public async Task<IActionResult> GetEmployeeDropdown()
        {
            var employees = await api.Get<IEnumerable<Employee>>("employee");

            var employeesDropdown = employees.Select(m => new SelectListItem
            {
                Text = m.FirstName +" "+m.LastName,
                Value = m.Id.ToString()
            }).ToList();

            return Json(employeesDropdown);
        }
        public async Task<IActionResult> Select(int id)
        {
            var employee=await api.Get<Employee>($"employee/GetById/{id}");
            return View(employee);
        }
        public IActionResult Create()
        {
            var model=new Employee();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Employee model)
        {
            if(!ModelState.IsValid)return View(model);

            try
            {
                var result=await api.Post<Employee,int>("employee/",model);
                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                ViewBag.Error = $"Error: <br />Message: {ex.Message}<br />Inner Exception: {ex.InnerException}";
                return View(model);
            }
        }

        public IActionResult Permissions()
        {
            return View();
        }
        public async Task<JsonResult> GetEmployees()
        {
            var employees = await api.Get<IEnumerable<Employee>>("employee");
            return Json(employees);
        }
        public async Task<JsonResult> GetPermissions(int id)
        {
            var permissions = await api.Get<IEnumerable<EmployeePermissionsView>>($"auth2/GetPermissionsForEmployee/{id}");
            return Json(permissions);
        }
        public async Task<JsonResult> GetPermissionsArray(int id)
        {
            var permissions = await api.Get<IEnumerable<EmployeePermissionsView>>($"auth2/GetPermissionsForEmployee/{id}");
            var validAccess = permissions.Where(p => p.HasAccess).Select(p => p.FeatureId).ToArray();
            return Json(validAccess);
        }
        [HttpPost]
        public async Task<IActionResult> UpdatePermissions([FromBody] UpdateEmployeePermissionsView model)
        {
            try
            {
                var result = await api.Post<UpdateEmployeePermissionsView, bool>("auth2/UpdatePermissions", model);
                return Json("Success");
            }
            catch (Exception ex)
            {
                return Json("Error updating Permissions: " + ex.Message);
            }
        }
    }
        


    
}
            