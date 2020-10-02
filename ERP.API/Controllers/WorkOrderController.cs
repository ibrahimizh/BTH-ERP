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
using ERP.Models.Views;

namespace ERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkOrderController : Controller
    {
        private WorkOrderService db;
        
        public WorkOrderController(WorkOrderService service)
        {
            this.db=service;            
        }

        [HttpGet("GetList")]
        public ActionResult<IEnumerable<WorkOrder>> GetList()
        {
            try
            {
                var workOrders = db.List();
                return workOrders.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
        [HttpGet("GetById/{id}")]
        public ActionResult<WorkOrder> GetById(int id)
        {
            try
            {
                var workOrder=db.GetById(id);
                return workOrder;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //POST api/values
        [HttpPost]
        public int Post([FromBody] APIEmpIdModel<WorkOrder> value)
        {
            try
            {
                return db.Insert(value);
            }
            catch (Exception)
            {

                throw;
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
        
        [HttpPost("CreateTask")]
        public int CreateTask([FromBody] WorkOrderTask value)
        {
            try
            {
                return db.InsertTask(value);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("GetAllTasks")]
        public ActionResult<IEnumerable<WorkOrderTaskView>> GetAllTasks()
        {
            try
            {
                var tasks = db.SelectAllTasks();
                return tasks.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("GetTasks/{id}")]
        public ActionResult<IEnumerable<WorkOrderTaskView>> GetTasks(int id)
        {
            try
            {
                var tasks = db.SelectTasks(id);
                return tasks.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("GetFilteredTasks")]
        public IEnumerable<WorkOrderTaskView> GetFilteredTasks([FromBody] FilterTaskModel value)
        {
            try
            {
                return db.SelectFilteredTasks(value);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("GetTaskById/{id}")]
        public ActionResult<WorkOrderTaskView> GetTaskById(int id)
        {
            try
            {
                var task=db.GetTaskById(id);
                return task;
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpPost("UpdateTask")]
        public bool UpdateTask([FromBody] WorkOrderTask value)
        {
            try
            {
                return db.UpdateTask(value);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("StartTask/{id}")]
        public bool StartTask(int id)
        {
            try
            {
                return db.StartTask(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("EndTask")]
        public bool EndTask([FromBody] UpdateWorkOrderTaskModel value)
        {
            try
            {
                var endTime=(value.Timestamp!=null)?value.Timestamp:DateTime.Now;
                return db.EndTask(value.TaskId,endTime);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("AddMaterialsUse")]
        public bool AddMaterialsUse([FromBody] APIEmpIdModel<WorkOrderMaterials> value)
        {
            try
            {
                return db.AddMaterialUse(value);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("GetMaterialsUsed/{id}")]
        public ActionResult<IEnumerable<WorkOrderMaterials>> GetMaterialsUsed(int id)
        {
            try
            {
                var materials = db.GetMaterialsUsed(id);
                return materials.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("UpdateStatus")]
        public bool UpdateStatus([FromBody] APIEmpIdModel<UpdateWorkOrderStatusModel> value)
        {
            try
            {
                return db.UpdateStatus(value);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        [HttpPost("AddCustomerPayment")]
        public bool AddCustomerPayment([FromBody] APIEmpIdModel<CustomerPayments> value)
        {
            try
            {
                return db.AddCustomerPayment(value);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("GetCustomerPayments/{id}")]
        public ActionResult<IEnumerable<CustomerPayments>> GetCustomerPayments(int id)
        {
            try
            {
                var payments = db.GetCustomerPayments(id);
                return payments.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("GetPagedWorkOrders")]
        public ActionResult<PagedList<WorkOrderView>> GetPagedWorkOrders(int pageNumber)
        {
            try
            {
                return db.GetPagedWorkOrders(pageNumber);
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpPost("AddInvoiceItem")]
        public ActionResult<InvoiceView> AddInvoiceItem([FromBody] WorkOrderItems value)
        {
            try
            {
                var result= db.AddInvoiceItem(value);
                var invoice = db.GetInvoice(value.WorkOrderId);
                return invoice;
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("GetInvoice/{id}")]
        public ActionResult<InvoiceView> GetInvoice(int id)
        {
            try
            {
                var invoice = db.GetInvoice(id);
                return invoice;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("ApplyDiscount")]
        public ActionResult<bool> ApplyDiscount([FromBody] DiscountView value)
        {
            try
            {
                var result = db.ApplyDiscount(value);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("SetCustomerPONumber")]
        public ActionResult<bool> SetCustomerPONumber([FromBody] CustomerPONumberView value)
        {
            try
            {
                var result = db.SetCustomerPONumber(value);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("GetReportData")]
        public IEnumerable<WorkOrderView> GetReportData([FromBody] WorkOrderFilter value)
        {
            try
            {
                return db.GetFilteredOrders(value);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost("GetPaymentReport")]
        public IEnumerable<PaymentReportView> GetPaymentReport([FromBody] PaymentReportFilter value)
        {
            try
            {
                return db.GetFilteredPayments(value);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost("UpdateInvoice")]
        public bool UpdateInvoice([FromBody] APIEmpIdModel<WorkOrderItemsUpdateModel> value)
        {
            try
            {
                return db.UpdateWorkOrderItems(value);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [HttpPost("LogPrintEvent")]
        public bool LogPrintEvent([FromBody] APIEmpIdModel<int> value)
        {
            try
            {
                return db.LogPrintEvent(value);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }

}