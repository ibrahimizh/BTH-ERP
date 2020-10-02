using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ERP.Models;
using ERP.Models.Views;
using ERP.Web.Helpers;
using ERP.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ERP.Web.Controllers
{
    [Authorize]
    public class PurchaseOrderController : Controller
    {
        static HttpClient client = new HttpClient();
        private IAPIHelper api;

        public PurchaseOrderController(IAPIHelper helper)
        {
            this.api=helper;
        }

        public async Task<IActionResult> List(){
            try
            {
                var orders = new AllPurchaseOrdersVM();

                orders.DraftOrders = await api.Get<IEnumerable<PurchaseOrderSimpleView>>("PurchaseOrder/GetDraftOrders");
                orders.ConfirmedOrders = await api.Get<IEnumerable<PurchaseOrderSimpleView>>("PurchaseOrder/GetConfirmedOrders");
                orders.ReceivedOrders = await api.Get<IEnumerable<PurchaseOrderSimpleView>>("PurchaseOrder/GetReceivedOrders");

                return View(orders);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        // public async Task<IActionResult> SelectDraft(int id)
        // {
        //     var draftOrder=await api.Get<PurchaseOrderSimpleView>($"PurchaseOrder/GetDraftById/{id}");
        //     var draftOrderView=new DraftPurchaseOrderVM();
        //     draftOrderView.DraftOrder=draftOrder;
        //     return View(draftOrderView);
        // }
        public async Task<IActionResult> Create()
        {
            var model=new DraftPurchaseOrderVM();
            model.Suppliers=await api.Get<IEnumerable<SelectListItem>>("Suppliers/GetDropDown");
            return View(model);
        }

        

        [HttpPost]
        public async Task<IActionResult> Create(int id)
        {
            
            try
            {
                var newOrder=new PurchaseOrderSimpleView(){SupplierId=id};

                var apiModel = new APIEmpIdModel<PurchaseOrderSimpleView>();
                apiModel.EmployeeId = int.Parse(User.Claims.Single(c => c.Type == "userid").Value);
                apiModel.Model = newOrder;

                var result=await api.Post<APIEmpIdModel<PurchaseOrderSimpleView>, int>("PurchaseOrder/",apiModel);
                //return RedirectToAction("Draft",new{id=result});
                return Json(result);
            }
            catch (Exception ex)
            {
                var error = $"Error: <br />Message: {ex.Message}<br />Inner Exception: {ex.InnerException}";
                return Json(error);
            }
        }


        public async Task<IActionResult> Draft(int id)
        {
            var draftOrder=await api.Get<PurchaseOrderDetailedView>($"PurchaseOrder/GetDraftById/{id}");
            //model.Items=await api.Get<IEnumerable<PurchaseOrderItemView>>($"PurchaseOrder/GetItems/{id}");
            var materials=await api.Get<IEnumerable<Materials>>("materials");
            var model=new DraftPurchaseOrderVM();
            model.DraftOrder=draftOrder;
            model.Materials=materials.ToList().Select(x=>new SelectListItem{
                Text=x.Name,
                Value=x.Id.ToString()
            }).ToList();
            ViewBag.ConfirmPOClass=(draftOrder.Items.Count()>0)?"show":"hide";
            return View(model);
        }

        public async Task<IActionResult> AddItem([FromBody] PurchaseOrderItem model)
        {
            var result=await api.Post<PurchaseOrderItem,int>("PurchaseOrder/AddItem/",model);
            return Json(result);
        }

        public async Task<IActionResult> RemoveItem(long id)
        {
            var result=await api.Get<bool>($"PurchaseOrder/RemoveItem/{id}");
            return Json(result);
        }

        [HttpPost]
        public async Task<IActionResult> Confirm([FromBody]SimpleModel<int> model)
        {
            var apiModel = new APIEmpIdModel<int>();
            apiModel.EmployeeId = int.Parse(User.Claims.Single(c => c.Type == "userid").Value);
            apiModel.Model = model.Value;

            var result = await api.Post<APIEmpIdModel<int>, bool>("PurchaseOrder/Confirm", apiModel);

            //var result=await api.Get<bool>($"PurchaseOrder/Confirm/{id}");
            //return RedirectToAction("Confirmed",new{id=model});
            return Json(result);
        }

        public async Task<IActionResult> Confirmed(int id)
        {
            var model=await api.Get<PurchaseOrderDetailedView>($"PurchaseOrder/GetConfirmedById/{id}");
            //model.Items=await api.Get<IEnumerable<PurchaseOrderItemView>>($"PurchaseOrder/GetItems/{id}");
            foreach(var item in model.Items)
            {
                item.ReceivedQuantity=item.OrderedQuantity;
            }          

            return View(model);
        }
        
        [HttpPost]
        public async Task<IActionResult> Receive([FromBody]PurchaseOrderDetailedView model)
        {
            var apiModel = new APIEmpIdModel<PurchaseOrderDetailedView>();
            apiModel.EmployeeId = int.Parse(User.Claims.Single(c => c.Type == "userid").Value);
            apiModel.Model = model;

            var result = await api.Post<APIEmpIdModel<PurchaseOrderDetailedView>, bool>("PurchaseOrder/Receive", apiModel);
            //var result = await api.Post<PurchaseOrderDetailedView,bool>("PurchaseOrder/Receive",model);
            //return RedirectToAction("List");
            return Json(result);
        }

        public async Task<IActionResult> Received(int id)
        {
            var model=await api.Get<PurchaseOrderDetailedView>($"PurchaseOrder/GetReceivedById/{id}");
            return View(model);
        }

        public async Task<IActionResult> GetSupplierPayments(int id)
        {
            try
            {
                var payments = await api.Get<IEnumerable<SupplierPaymentsView>>($"PurchaseOrder/GetSupplierPaymentsByPurchaseOrder/{id}");
                return Json(payments);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPost]
        public async Task<IActionResult> AddSupplierPayment([FromBody]AddSupplierPaymentModel model)
        {
            var apiModel = new APIEmpIdModel<AddSupplierPaymentModel>();
            apiModel.EmployeeId = int.Parse(User.Claims.Single(c => c.Type == "userid").Value);
            apiModel.Model = model;
            var result = await api.Post<APIEmpIdModel<AddSupplierPaymentModel>, bool>("PurchaseOrder/AddSupplierPayment", apiModel);
            return Json(result);
        }

        [HttpGet]
        public ActionResult GetSupplierPaymentsReport()
        {
            return View("SupplierPaymentsReport");

        }

        [HttpPost]
        public async Task<IActionResult> GetSupplierPaymentsReport([FromBody]SupplierPaymentReportFilter model)
        {
            try
            {
                var payments = await api.Post<SupplierPaymentReportFilter,IEnumerable<SupplierPaymentReport>>("PurchaseOrder/GetSupplierPaymentReport",model);
                return Json(payments);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<IActionResult> GetEvents(int id)
        {
            try
            {
                var events = await api.Get<IEnumerable<ERPeventView>>($"ERPevents/GetPurchaseOrderEvents/{id}");
                return Json(events);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
        


    
}
            