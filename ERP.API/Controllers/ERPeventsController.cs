using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP.API.Data.Services;
using ERP.Models.Views;
using Microsoft.AspNetCore.Mvc;

namespace ERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ERPeventsController : Controller
    {
        private ERPeventService db;
        public ERPeventsController(ERPeventService db)
        {
            this.db = db;
        }

        [HttpGet("GetPurchaseOrderEvents/{id}")]
        public ActionResult<IEnumerable<ERPeventView>> GetPurchaseOrderEvents(int id)
        {
            try
            {
                var purchaseOrderEvents = db.GetPurchaseOrderEvents(id);
                return purchaseOrderEvents.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("GetEnquiryEvents/{id}")]
        public ActionResult<IEnumerable<ERPeventView>> GetEnquiryEvents(int id)
        {
            try
            {
                var enquiryEvents = db.GetEnquiryEvents(id);
                return enquiryEvents.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("GetWorkOrderEvents/{id}")]
        public ActionResult<IEnumerable<ERPeventView>> GetWorkOrderEvents(int id)
        {
            try
            {
                var enquiryEvents = db.GetWorkOrderEvents(id);
                return enquiryEvents.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}