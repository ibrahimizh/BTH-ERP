using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ERP.Models;
using System.Text;
using Microsoft.Extensions.Options;
using ERP.API.Models;
using ERP.API.Data;
using System.Linq;
using System;
using ERP.API.Data.Services;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeesService db;

        public EmployeeController(IEmployeesService service)
        {
            this.db = service;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            try
            {
                var employees = db.GetAll().ToList();
                return employees;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpGet("GetById/{id}")]
        public ActionResult<Employee> GetById(int id)
        {
            try
            {
                return db.GetById(id);
            }
            catch (Exception)
            {

                throw;
            }

        }

        // POST api/values
        [HttpPost]
        public int Post([FromBody] Employee value)
        {
            try
            {
                return db.Add(value);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("GetDropDown")]
        public ActionResult<IEnumerable<SelectListItem>> GetDropDown()
        {
            var employees = db.GetDropDown().ToList();
            return employees;
        }

    }
}