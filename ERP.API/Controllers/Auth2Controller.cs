using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP.API.Data.Services;
using ERP.Models.Views;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Auth2Controller : ControllerBase
    {
        private AuthService db;
        public Auth2Controller(AuthService db)
        {
            this.db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("GetPermissionsForEmployee/{id}")]
        public ActionResult<IEnumerable<EmployeePermissionsView>> GetPermissionsForEmployee(int id)
        {
            try
            {
                var employeePermissions = db.GetPermissionsById(id);
                return employeePermissions.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("UpdatePermissions")]
        public bool UpdatePermissions([FromBody] UpdateEmployeePermissionsView value)
        {
            try
            {
                return db.UpdatePermissions(value);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}