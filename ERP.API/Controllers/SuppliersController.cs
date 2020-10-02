using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP.API.Data;
using ERP.API.Data.Services;
using ERP.Models;
using ERP.Models.Views;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private ISuppliersService db;
        private IDbContext dbContext;
        public SuppliersController(IDbContext dbContext,ISuppliersService db)
        {
            this.dbContext=dbContext;
            this.db=db;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<SuppliersView>> Get()
        {
            var suppliers=db.GetAll().ToList();
            return suppliers;
        }

        // // // GET api/values/5
        // [HttpGet("GetByCode/{code}")]
        // public ActionResult<Materials> GetByCode(string code)
        // {
        //     return db.GetByCode(code);

        // }

        // POST api/values
        [HttpPost]
        public int Post([FromBody] APIEmpIdModel<Suppliers> value)
        {
            return db.Add(value);
        }

        [HttpGet("GetDropDown")]
        public ActionResult<IEnumerable<SelectListItem>> GetDropDown()
        {
            var suppliers=db.GetDropDown().ToList();
            return suppliers;
        }

        // // PUT api/values/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody] string value)
        // {
        // }

        // // DELETE api/values/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }
    }
}