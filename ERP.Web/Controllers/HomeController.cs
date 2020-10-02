using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERP.Web.Models;
using Microsoft.AspNetCore.Authorization;
using ERP.Web.Helpers;
using ERP.Models.Views;
using Microsoft.AspNetCore.Http;

namespace ERP.Web.Controllers
{
    //[Authorize(AuthenticationSchemes = "oidc")]
    [Authorize]
    public class HomeController : Controller
    {
        private IAPIHelper api;
        private readonly IHttpContextAccessor _httpContextAccessor;

        //public HomeController(IAPIHelper helper, IHttpContextAccessor httpContextAccessor)
        //{
        //    this._httpContextAccessor = httpContextAccessor;
        //    this.api = helper;
        //}
        public HomeController(IAPIHelper helper)
        {
            this.api = helper;
        }
        public IActionResult Index()
        {
            //var permissions = await api.Get<IEnumerable<EmployeePermissionsView>>($"auth2/GetPermissionsForEmployee/{User.Claims.FirstOrDefault(c => c.Type == "userid").Value}");
            //var employeeFeatures = string.Join(",", permissions.Select(p => p.FeatureId.ToString()).ToList());
            //User.Claims.Where(c => c.Type == "features").ToList().Clear();
            //User.AddIdentity(new System.Security.Claims.ClaimsIdentity() { Claims=new List<Claim>})
            //string cookieValueFromContext = _httpContextAccessor.HttpContext.Request.Cookies["key"];
            //read cookie from Request object  
            //Response.Cookies.Delete("Features");
            //Response.Cookies.Append("Features", employeeFeatures);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
