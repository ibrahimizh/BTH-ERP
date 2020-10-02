using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
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
    public class WorkOrderController:Controller
    {
        private DateTime July01_2020 = DateTime.ParseExact("01/07/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture);
        private IAPIHelper api;

        public WorkOrderController(IAPIHelper helper)
        {
            this.api=helper;
        }

        public async Task<IActionResult> List(){
            //var workOrders=await api.Get<IEnumerable<WorkOrder>>("WorkOrder/GetList");
            //return View(workOrders);
            return RedirectToAction("PagedList");
        }
        public async Task<IActionResult> PagedList(int pageNumber=0,int totalCount=0)
        {
            //if (pageNumber >= totalCount) pageNumber -=1;
            //if (pageNumber <0) pageNumber = 0;
            var workOrders = await api.Get<PagedList<WorkOrderView>>($"WorkOrder/GetPagedWorkOrders?pageNumber={pageNumber}");
            return View(workOrders);
        }
        public ActionResult Reports()
        {
            //var claim = User.Claims.Single(c => c.Type == "role").Value;
            //if (claim == "admin")
            //{
            //    return View();
            //}
            //else return View("NoAccess");            
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Reports([FromBody]WorkOrderFilter model)
        {
            var result = await api.Post<WorkOrderFilter, IEnumerable<WorkOrderView>>("WorkOrder/GetReportData", model);
            return Json(result);
        }
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                var employees = await api.Get<IEnumerable<SelectListItem>>("Employee/GetDropDown");
                var workOrderVM = new WorkOrderVM();
                var workOrder = await api.Get<WorkOrder>($"WorkOrder/GetById/{id}");
                workOrderVM.WorkOrderDetail = workOrder;
                
                workOrderVM.CreateTaskVM.Employees = employees;
                return View("Details", workOrderVM);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public ActionResult Create(int id){
            var workOrder=new WorkOrder();
            workOrder.ProposalId=id;
            workOrder.VAT= (DateTime.Today < July01_2020) ? (byte)5 : (byte)15;
            return View(workOrder);
        }

        [HttpPost]
        public async Task<IActionResult> Create(WorkOrder model)
        {
            if(!ModelState.IsValid)return View(model);
            ViewBag.Success="";
            ViewBag.Error="";
            try{
                var apiModel = new APIEmpIdModel<WorkOrder>();
                apiModel.EmployeeId = int.Parse(User.Claims.Single(c => c.Type == "userid").Value);
                model.VAT = (DateTime.Today < July01_2020) ? (byte)5 : (byte)15;
                apiModel.Model = model;
                var result=await api.Post<APIEmpIdModel<WorkOrder>,int>("WorkOrder/",apiModel);
                if(result>0)return RedirectToAction("Details",new{id=result});
                else ViewBag.Error="Error saving WorkOrder";
            }
            catch(Exception ex)
            {
                ViewBag.Error="Error saving WorkOrder: "+ex.Message;
            }
            return View(model);
        }

        public async Task<IActionResult> CreateTask()
        {
            var model=new CreateWorkOrderTaskVM();
            model.Employees=await api.Get<IEnumerable<SelectListItem>>("Employee/GetDropDown");
            return View(model);
        }

        [HttpPost]
        public async Task<JsonResult> CreateTask([FromBody]PostWorkOrderTask model){
            try{
                var newTask=new WorkOrderTask{
                    WorkOrderId=model.WorkOrderId,
                    EmployeeId=model.EmployeeId,
                    Description=model.Description,
                    TargetDate=model.TargetDate,
                    WorkOrderItemId=model.WorkOrderItemId
                };
                var result=await api.Post<WorkOrderTask,int>("WorkOrder/CreateTask",newTask);
                return (result>0)? Json(true):Json(false);
            }
            catch
            {
                return Json(false);
            }

        }
        public async Task<IActionResult> TaskReport()
        {
            try
            {
                var WorkOrderTask = await api.Get<IEnumerable<WorkOrderTaskView>>($"WorkOrder/GetAllTasks");
                return View(WorkOrderTask);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        [HttpPost]
        public async Task<IActionResult> GetFilteredTaskReport([FromBody] FilterTaskModel model)
        {
            try
            {
                var result = await api.Post<FilterTaskModel, IEnumerable<WorkOrderTaskView>>("WorkOrder/GetFilteredTasks", model);
                return PartialView("_TaskReport", result);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public async Task<IActionResult> GetTasks(int id)
        {
            
            try
            {
                var WorkOrderTask = await api.Get<IEnumerable<WorkOrderTaskView>>($"WorkOrder/GetTasks/{id}");
                if(!(User.Claims.Single(c => c.Type == "features").Value.Contains("22") || User.Claims.Single(c => c.Type == "role").Value == "admin"))
                {
                    var filteredTasks = WorkOrderTask.Where(wt => wt.EmployeeId == int.Parse(User.Claims.Single(c => c.Type == "userid").Value));
                    WorkOrderTask = filteredTasks;
                }
                return PartialView("_TaskList",WorkOrderTask);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public async Task<IActionResult> GetTaskDetails(int id)
        {
            try{
                var taskDetails = await api.Get<WorkOrderTaskView>($"WorkOrder/GetTaskById/{id}");
                return PartialView("_TaskDetails",taskDetails);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public async Task<JsonResult> UpdateTask([FromBody]WorkOrderTask model){
            try{
                var result=await api.Post<WorkOrderTask,bool>("WorkOrder/UpdateTask",model);
                return Json(result);
            }
            catch
            {
                return Json(false);
            }

        }

        public async Task<IActionResult> GetMaterials(int id)
        {
            try{
                var materials = await api.Get<IEnumerable<WorkOrderMaterials>>($"WorkOrder/GetMaterialsUsed/{id}");
                return Json(materials);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> AddMaterialUsed([FromBody]WorkOrderMaterials model)
        {
            try{
                var apiModel = new APIEmpIdModel<WorkOrderMaterials>();
                apiModel.EmployeeId = int.Parse(User.Claims.Single(c => c.Type == "userid").Value);
                apiModel.Model = model;
                var result=await api.Post<APIEmpIdModel<WorkOrderMaterials>, bool>("WorkOrder/AddMaterialsUse",apiModel);
                return Json(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateStatus([FromBody] UpdateWorkOrderStatusModel model)
        {
            try{
                var apiModel = new APIEmpIdModel<UpdateWorkOrderStatusModel>();
                apiModel.EmployeeId = int.Parse(User.Claims.Single(c => c.Type == "userid").Value);
                apiModel.Model = model;

                var result=await api.Post<APIEmpIdModel<UpdateWorkOrderStatusModel>,bool>("WorkOrder/UpdateStatus",apiModel);
                return Json(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public async Task<IActionResult> EndTask([FromBody] UpdateWorkOrderTaskModel model)
        {
            try{
                var result=await api.Post<UpdateWorkOrderTaskModel,bool>("WorkOrder/EndTask",model);
                return Json(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IActionResult> GetCustomerPayments(int id)
        {
            try{
                var payments = await api.Get<IEnumerable<CustomerPayments>>($"WorkOrder/GetCustomerPayments/{id}");
                return Json(payments);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomerPayment([FromBody]CustomerPayments model)
        {
            try{
                var apiModel = new APIEmpIdModel<CustomerPayments>();
                apiModel.EmployeeId = int.Parse(User.Claims.Single(c => c.Type == "userid").Value);
                apiModel.Model = model;
                var result=await api.Post<APIEmpIdModel<CustomerPayments>, bool>("WorkOrder/AddCustomerPayment",apiModel);
                return Json(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddInvoiceItem([FromBody]WorkOrderItems model)
        {
            try
            {
                var result = await api.Post<WorkOrderItems, InvoiceView>("WorkOrder/AddInvoiceItem", model);
                return Json(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IActionResult> GetInvoice(int id)
        {
            try
            {
                var invoice = await api.Get<InvoiceView>($"WorkOrder/GetInvoice/{id}");
                return Json(invoice);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPost]
        public async Task<IActionResult> ApplyDiscount([FromBody] DiscountView value)
        {
            try
            {
                var result = await api.Post<DiscountView, bool>("WorkOrder/ApplyDiscount", value);
                return Json(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public async Task<IActionResult> SetCustomerPONumber([FromBody] CustomerPONumberView value)
        {
            try
            {
                var result = await api.Post<CustomerPONumberView, bool>("WorkOrder/SetCustomerPONumber", value);
                return Json(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateInvoice([FromBody]WorkOrderItemsUpdateModel model)
        {
            try
            {
                var apiModel = new APIEmpIdModel<WorkOrderItemsUpdateModel>();
                apiModel.EmployeeId = int.Parse(User.Claims.Single(c => c.Type == "userid").Value);
                apiModel.Model = model;
                var result = await api.Post<APIEmpIdModel<WorkOrderItemsUpdateModel>, bool>("WorkOrder/UpdateInvoice", apiModel);
                return Json(result);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        [HttpGet]
        public ActionResult PaymentReport()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GetFilteredPaymentReport([FromBody] PaymentReportFilter model)
        {
            try
            {
                var resultData = new PaymentReportDetailedView();
                var result= await api.Post<PaymentReportFilter, IEnumerable<PaymentReportView>>("WorkOrder/GetPaymentReport", model); ;
                resultData.ReportData = result;
                resultData.CashTotal = result.Where(r => r.PaymentTypeId == (byte)PaymentOptions.Cash).Sum(r=>r.Amount);
                resultData.BankTransferTotal = result.Where(r => r.PaymentTypeId == (byte)PaymentOptions.BankTransfer).Sum(r => r.Amount);
                resultData.ChequeTotal = result.Where(r => r.PaymentTypeId == (byte)PaymentOptions.Cheque).Sum(r => r.Amount);
                resultData.PointOfSaleTotal = result.Where(r => r.PaymentTypeId == (byte)PaymentOptions.PointOfSale).Sum(r => r.Amount);
                
                return Json(resultData);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPost]
        public async Task<IActionResult> LogPrintEvent(int id)
        {
            var apiModel = new APIEmpIdModel<int>();
            apiModel.EmployeeId = int.Parse(User.Claims.Single(c => c.Type == "userid").Value);
            apiModel.Model = id;
            var result = await api.Post<APIEmpIdModel<int>, bool>("WorkOrder/LogPrintEvent", apiModel);
            return Json(result);
        }

        public async Task<IActionResult> GetEvents(int id)
        {
            try
            {
                var events = await api.Get<IEnumerable<ERPeventView>>($"ERPevents/GetWorkOrderEvents/{id}");
                return Json(events);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public ActionResult Test()
        {
            return View();
        }
    }
    
}