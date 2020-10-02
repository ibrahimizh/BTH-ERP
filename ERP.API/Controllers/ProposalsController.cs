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
using ERP.Models.Views;

namespace ERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProposalsController : Controller
    {
        private ProposalService db;
        
        public ProposalsController(ProposalService service)
        {
            this.db=service;            
        }

        [HttpGet("GetProposals")]
        public ActionResult<IEnumerable<ProposalViewModel>> GetProposals()
        {
            try
            {
                var proposals = db.GetProposals();
                return proposals.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
        [HttpGet("GetProposalById/{id}")]
        public ActionResult<ProposalViewModel> GetProposalById(int id)
        {
            try
            {
                var proposal=db.GetProposalById(id);
                return proposal;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //POST api/values
        [HttpPost]
        public int Post([FromBody] APIEmpIdModel<ProposalVM> value)
        {
            try
            {
                return db.InsertProposal(value);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("GetQuote/{id}")]
        public ActionResult<QuoteView> GetQuote(int id)
        {
            try
            {
                var quote = db.GetQuote(id);
                return quote;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("UpdateQuote")]
        public int UpdateQuote([FromBody] APIEmpIdModel<ProposalItemsUpdateModel> value)
        {
            try
            {
                return db.UpdateProposalItems(value);
            }
            catch (Exception e)
            {

                throw e;
            }
        }



        // [HttpPost("Confirm/{id}")]
        // public ActionResult Confirm(int id)
        // {
        //     try{
        //         db.
        //         return Json("Success");
        //     }
        //     catch(Exception ex){
        //         return Json(ex);
        //     }

        // }



    }

}