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
    public class PurchaseOrderController : Controller
    {
        private PurchaseOrderService db;
        
        public PurchaseOrderController(PurchaseOrderService service)
        {
            this.db=service;            
        }

        // GET api/values
        [HttpGet("GetDraftOrders")]
        public ActionResult<IEnumerable<PurchaseOrderSimpleView>> GetDraftOrders()
        {
            try
            {
                var draftOrders = db.GetDraftOrders();
                return draftOrders.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
        [HttpGet("GetDraftById/{id}")]
        public ActionResult<PurchaseOrderDetailedView> GetDraftById(int id)
        {
            try
            {
                var draftOrder=db.GetDraftOrderById(id);
                var items = db.GetPurchaseOrderItems(id);
                var result=new PurchaseOrderDetailedView();

                result.Id=draftOrder.Id;
                result.CreatedDate=draftOrder.CreatedDate;
                result.SupplierId=draftOrder.SupplierId;
                result.SupplierName=draftOrder.SupplierName;

                result.Items=items;
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //POST api/values
        [HttpPost]
        public int Post([FromBody] APIEmpIdModel<PurchaseOrderSimpleView> value)
        {
            try
            {
                return db.InsertPurchaseOrderDraft(value);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("AddItem")]
        public long AddItem([FromBody] PurchaseOrderItem value)
        {
            try
            {
                return db.AddPurchaseOrderItem(value);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("RemoveItem/{id}")]
        public bool RemoveItem(long id)
        {
            try
            {
                return db.RemovePurchaseOrderItem(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("Confirm")]
        public bool Confirm(APIEmpIdModel<int> id)
        {
            try
            {
                return db.ConfirmPurchaseOrder(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("GetItems/{id}")]
        public ActionResult<IEnumerable<PurchaseOrderItemView>> GetItems(int id)
        {
            try
            {
                var items = db.GetPurchaseOrderItems(id);
                return items.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("GetConfirmedOrders")]
        public ActionResult<IEnumerable<PurchaseOrderSimpleView>> GetConfirmedOrders()
        {
            try
            {
                var confirmedOrders = db.GetConfirmedOrders();
                return confirmedOrders.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
        [HttpGet("GetConfirmedById/{id}")]
        public ActionResult<PurchaseOrderDetailedView> GetConfirmedById(int id)
        {
            try
            {
                var confirmedOrder= db.GetConfirmedOrderById(id);
                var items = db.GetPurchaseOrderItems(id);

                var result=new PurchaseOrderDetailedView();
                
                result.Id=confirmedOrder.Id;
                result.CreatedDate=confirmedOrder.CreatedDate;
                result.OrderedDate=confirmedOrder.OrderedDate;
                result.SupplierId=confirmedOrder.SupplierId;
                result.SupplierName=confirmedOrder.SupplierName;
                
                result.Items=items;

                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpPost("Receive")]
        public bool Receive([FromBody] APIEmpIdModel<PurchaseOrderDetailedView> model)
        {
            try{
                db.SetPurchaseOrderReceiving(model);
                return true;
            }
            catch(Exception ex){
                throw;
            }
            
        }
        
        [HttpGet("GetReceivedOrders")]
        public ActionResult<IEnumerable<PurchaseOrderSimpleView>> GetReceivedOrders()
        {
            try
            {
                var receivedOrders = db.GetReceivedOrders();
                return receivedOrders.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("GetReceivedById/{id}")]
        public ActionResult<PurchaseOrderDetailedView> GetReceivedById(int id)
        {
            try
            {
                return db.GetReceivedOrderById(id);
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpPost("AddSupplierPayment")]
        public bool AddSupplierPayment([FromBody] APIEmpIdModel<AddSupplierPaymentModel> model)
        {
            try
            {
                var add= db.AddSupplierPayment(model);
                //var supplierPayments = db.GetSupplierPaymentsByPurchaseOrder(value.PurchaseOrderId);
                //return Json(supplierPayments.ToList());
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("GetSupplierPaymentsByPurchaseOrder/{id}")]
        public ActionResult<IEnumerable<SupplierPaymentsView>> GetSupplierPaymentsByPurchaseOrder(int id)
        {
            try
            {
                var supplierPayments = db.GetSupplierPaymentsByPurchaseOrder(id);
                return supplierPayments.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("GetSupplierPaymentReport")]
        public ActionResult<IEnumerable<SupplierPaymentReport>> GetSupplierPaymentReport([FromBody] SupplierPaymentReportFilter value)
        {
            try
            {
                var supplierPaymentReport = db.GetSupplierPaymentReport(value);
                return supplierPaymentReport.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}