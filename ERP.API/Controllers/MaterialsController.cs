using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP.API.Data;
using ERP.API.Data.Services;
using ERP.API.Models;
using ERP.Models;
using ERP.Models.Views;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialsController : ControllerBase
    {
        private IMaterialsService db;
        // private readonly IOptions<ConfigurationSettings> configuration; 
        private IDbContext dbContext;
        public MaterialsController(IDbContext dbContext,IMaterialsService service)
        {
            this.dbContext=dbContext;
            this.db=service;
            //db=new MaterialsService(this.dbContext);
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<MaterialsView>> Get()
        {
            try
            {
                var materials = db.GetAll().ToList();
                return materials;
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // // GET api/values/5
        [HttpGet("GetByCode/{code}")]
        public ActionResult<Materials> GetByCode(string code)
        {
            try
            {
                return db.GetByCode(code);
            }
            catch (Exception)
            {

                throw;
            }

        }
        [HttpGet("GetById/{id}")]
        public ActionResult<Materials> GetById(int id)
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
        [HttpPost("CodeDuplicationCheckForUpdate")]
        public bool CodeDuplicationCheckForUpdate([FromBody] KeyValue material)
        {
            try
            {
                return db.CodeDuplicationCheckForUpdate(material);
            }
            catch (Exception)
            {

                throw;
            }

        }

        // POST api/values
        [HttpPost]
        public int Post([FromBody] APIEmpIdModel<Materials> value)
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
        
        [HttpPost("Update")]
        public bool Update([FromBody] Materials value)
        {
            try
            {
                return db.Update(value);
            }
            catch (Exception)
            {

                throw;
            }
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
