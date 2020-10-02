using System;
using ERP.Models;
using ERP.API.Data.Queries;
using System.Collections.Generic;
using ERP.Models.Views;
using System.Linq;
using System.Text;

namespace ERP.API.Data.Services
{
    public class WorkOrderService
    {
        private IDbContext dbContext;

        public WorkOrderService(IDbContext dbContext)
        {
            this.dbContext=dbContext;
        }

        public int Insert(APIEmpIdModel<WorkOrder> model){
            try
            {
                var proposalService = new ProposalService(dbContext);
                var proposal = proposalService.GetProposalById(model.Model.ProposalId);
                model.Model.BusinessPartnerId = proposal.BusinessPartnerId;
                model.Model.BusinessPartnerContactId = proposal.BusinessPartnerContactId;
                var query = WorkOrderQueries.Add;
                var parameters = DataHelper.ExtractParameters(model.Model);
                var workorderId= dbContext.Execute<int>(query, parameters);
                var queryLines = WorkOrderQueries.CopyItemsFromProposal;
                var parametersLines = DataHelper.ExtractParameters(new { WorkOrderId = workorderId, ProposalId= model.Model.ProposalId });
                dbContext.ExecuteNonQuery(queryLines, parametersLines);
                if (proposal.Discount.HasValue)
                {
                    var discountModel = new DiscountView { Discount = proposal.Discount.Value, WorkOrderId = workorderId };
                    var res=ApplyDiscount(discountModel);
                }

                var erpEvent = new ERPEventHelper().GetEventModel(model.EmployeeId, workorderId, EventTypes.WorkOrderDrafted);
                dbContext.ExecuteNonQuery(EventQueries.EventInsert, DataHelper.ExtractParameters(erpEvent));

                return workorderId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<WorkOrder> List(){
            var query=WorkOrderQueries.GetAll;
            return dbContext.GetList<WorkOrder>(query);
        }

        public WorkOrder GetById(int id)
        {
            var query=WorkOrderQueries.GetById;
            var parameters=DataHelper.ExtractParameters(new{Id=id});
            return dbContext.Get<WorkOrder>(query,parameters);
        }

        // public bool Confirm(int id)
        // {

        // }

        public int InsertTask(WorkOrderTask newTask){
            try
            {
                var query = WorkOrderQueries.CreateTask;
                var parameters = DataHelper.ExtractParameters(newTask);
                return dbContext.Execute<int>(query, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<WorkOrderTaskView> SelectAllTasks()
        {
            var query = WorkOrderQueries.SelectAllTasks;
            return dbContext.GetList<WorkOrderTaskView>(query);
        }
        //if (filter.CreatedFrom.HasValue) query.Append($"and date(Timestamp) > '{filter.CreatedFrom.Value.ToString("yyyy/MM/dd")}' ");
        //if (filter.CreatedTo.HasValue) query.Append($"and date(Timestamp) < '{filter.CreatedTo.Value.ToString("yyyy/MM/dd")}' ");

        public IEnumerable<WorkOrderTaskView> SelectFilteredTasks(FilterTaskModel model)
        {
            var query = WorkOrderQueries.SelectFilteredTasks;
            if (model.WorkOrderId.HasValue) query+=($" and T.WorkOrderId = {model.WorkOrderId}");
            if ((model.EmployeeId.HasValue)&& (model.EmployeeId>0))query += ($" and EmployeeId = {model.EmployeeId}");
            if (model.TargetDateFrom.HasValue) query += ($" and date(t.targetdate) >= '{model.TargetDateFrom.Value.ToString("yyyy-MM-dd")}'");
            if (model.TargetDateTo.HasValue) query += ($" and date(t.targetdate) <= '{model.TargetDateTo.Value.ToString("yyyy-MM-dd")}'");
            var parameters = DataHelper.ExtractParameters(model);
            return dbContext.GetList<WorkOrderTaskView>(query,parameters);
        }

        public IEnumerable<WorkOrderTaskView> SelectTasks(int id){
            var query=WorkOrderQueries.SelectTasks;
            var parameters = DataHelper.ExtractParameters(new { Id = id });
            return dbContext.GetList<WorkOrderTaskView>(query,parameters);
        }

        public WorkOrderTaskView GetTaskById(int id)
        {
            var query=WorkOrderQueries.SelectTaskById;
            var parameters=DataHelper.ExtractParameters(new{Id=id});
            return dbContext.Get<WorkOrderTaskView>(query,parameters);
        }

        public bool UpdateTask(WorkOrderTask task)
        {
            var query=WorkOrderQueries.UpdateTask;
            var parameters=DataHelper.ExtractParameters(new{Id=task.Id,StatusId=task.StatusId,Progress=task.Progress});
            dbContext.ExecuteNonQuery(query,parameters);
            return true;
        }

        public bool StartTask(int id)
        {
            var query=WorkOrderQueries.StartTask;
            var parameters=DataHelper.ExtractParameters(new{Id=id});
            dbContext.ExecuteNonQuery(query,parameters);
            return true;
        }

        public bool EndTask(int id,DateTime endTimestamp)
        {
            var query=WorkOrderQueries.EndTask;
            var parameters=DataHelper.ExtractParameters(new{Id=id,CompletedDate=endTimestamp});
            dbContext.ExecuteNonQuery(query,parameters);
            return true;
        }

        public bool AddMaterialUse(APIEmpIdModel<WorkOrderMaterials> model)
        {
            var query=WorkOrderQueries.AddMaterialUse;
            var parameters=DataHelper.ExtractParameters(new{MaterialId=model.Model.MaterialId,Units=model.Model.Units,WorkOrderId=model.Model.WorkOrderId});
            dbContext.ExecuteNonQuery(query,parameters);

            var erpEvent = new ERPEventHelper().GetEventModel(model.EmployeeId, model.Model.WorkOrderId, EventTypes.MaterialsConsumptionAdd);
            dbContext.ExecuteNonQuery(EventQueries.EventInsert, DataHelper.ExtractParameters(erpEvent));

            return true;
        }

        public IEnumerable<WorkOrderMaterials> GetMaterialsUsed(int workOrderId)
        {
            var query=WorkOrderQueries.SelectMaterialsUsed;
            var parameters = DataHelper.ExtractParameters(new { WorkOrderId = workOrderId });
            return dbContext.GetList<WorkOrderMaterials>(query,parameters);
        }

        public bool UpdateStatus(APIEmpIdModel<UpdateWorkOrderStatusModel> model)
        {
            var query =WorkOrderQueries.UpdateStatus;
            var parameters=DataHelper.ExtractParameters(new { StatusId = model.Model.Status,Id=model.Model.WorkOrderId });
            dbContext.ExecuteNonQuery(query,parameters);
            EventTypes eventType = 0;
            switch(model.Model.Status)
            {
                case 1:
                    eventType = EventTypes.WorkOrderDrafted;
                    break;
                case 2:
                    eventType = EventTypes.WorkOrderCreate;
                    break;
                case 3:
                    eventType = EventTypes.WorkOrderCancelled;
                    break;
                case 4:
                    eventType = EventTypes.WorkOrderComplete;
                    break;
            }
            var erpEvent = new ERPEventHelper().GetEventModel(model.EmployeeId, model.Model.WorkOrderId, eventType);
            dbContext.ExecuteNonQuery(EventQueries.EventInsert, DataHelper.ExtractParameters(erpEvent));

            return true;
        }

        public bool AddCustomerPayment(APIEmpIdModel<CustomerPayments> model)
        {
            var query=WorkOrderQueries.InsertCustomerPayment;
            var parameters = DataHelper.ExtractParameters(model.Model);
            dbContext.ExecuteNonQuery(query,parameters);

            var erpEvent = new ERPEventHelper().GetEventModel(model.EmployeeId, model.Model.WorkOrderId, EventTypes.CustomerPaymentAdd);
            dbContext.ExecuteNonQuery(EventQueries.EventInsert, DataHelper.ExtractParameters(erpEvent));

            return true;
        }

        public IEnumerable<CustomerPayments> GetCustomerPayments(int workOrderId)
        {
            var query=WorkOrderQueries.SelectCustomerPayments;
            var parameters = DataHelper.ExtractParameters(new { WorkOrderId = workOrderId });
            return dbContext.GetList<CustomerPayments>(query,parameters);
        }

        public PagedList<WorkOrderView> GetPagedWorkOrders(int pageNumber)
        {
            try
            {
                var query = "workorders_paged_selectall";
                var parameters = DataHelper.ExtractParameters(new { page_offeset = pageNumber*10 });
                var result= dbContext.GetListProcedure<WorkOrderView>(query, parameters);
                //result.PageNumber = (pageNumber==0)?1:pageNumber;
                result.PageNumber = pageNumber;
                result.TotalPages = (result.Count / 10);
                if (result.Count % 10 > 0) result.TotalPages += 1;
                return result;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public decimal AddInvoiceItem(WorkOrderItems model)
        {
            try
            {
                var query = WorkOrderQueries.AddInvoiceItem;
                var parameters = DataHelper.ExtractParameters(model);
                return dbContext.Get<decimal>(query, parameters);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        internal bool LogPrintEvent(APIEmpIdModel<int> model)
        {
            var erpEvent = new ERPEventHelper().GetEventModel(model.EmployeeId, model.Model, EventTypes.InvoicePrinted);
            dbContext.ExecuteNonQuery(EventQueries.EventInsert, DataHelper.ExtractParameters(erpEvent));
            return true;
        }

        public InvoiceView GetInvoice(int workOrderId)
        {
            var invoice = new InvoiceView();
            var query = WorkOrderQueries.GetInvoiceItems;
            var parameters = DataHelper.ExtractParameters(new { WorkOrderId = workOrderId });
            invoice.Items= dbContext.GetList<WorkOrderItemView>(query, parameters);
            if (invoice.Items.Count() > 0)
            {
                invoice.SubTotal = invoice.Items.ToList().Sum(t => t.LineTotal);
                invoice.Discount = invoice.Items.First().Discount;
                //invoice.VAT = ((invoice.SubTotal - invoice.Discount) * 5) / 100;
                //invoice.Total = (invoice.SubTotal- invoice.Discount) + invoice.VAT;
                invoice.VAT = (invoice.SubTotal * invoice.Items.First().VAT) / 100;
                invoice.Total = (invoice.SubTotal + invoice.VAT) - invoice.Discount;
            }
            return invoice;
        }

        public bool ApplyDiscount(DiscountView model)
        {
            var query = WorkOrderQueries.SetDiscount;
            var parameters = DataHelper.ExtractParameters(model);
            dbContext.ExecuteNonQuery(query, parameters);
            return true;
        }

        public bool SetCustomerPONumber(CustomerPONumberView model)
        {
            var query = WorkOrderQueries.SetCustomerPONumber;
            var parameters = DataHelper.ExtractParameters(model);
            dbContext.ExecuteNonQuery(query, parameters);
            return true;
        }
        //public IEnumerable<WorkOrderView> GetFilteredOrders(WorkOrderFilter filter)
        //{
        //    var query = new StringBuilder("select * from erp.v_work_orders where 1=1 ");
        //    if (filter.StatusId.HasValue) query.Append($"and StatusId={filter.StatusId.Value} ");
        //    if (filter.TargetDateFrom.HasValue) query.Append($"and TargetDate>='{filter.TargetDateFrom.Value}' ");
        //    if (filter.TargetDateTo.HasValue) query.Append($"and TargetDate<='{filter.TargetDateTo.Value}' ");
        //    query.Append(";");

        //}
        public IEnumerable<WorkOrderView> GetFilteredOrders(WorkOrderFilter filter)
        {
            var query = new StringBuilder("select * from erp.v_work_orders where 1=1 ");
            if (!string.IsNullOrEmpty(filter.CustomerName)) query.Append($"and Name like '%{filter.CustomerName}%' ");
            if (!string.IsNullOrEmpty(filter.MobileNo)) query.Append($"and MobileNo like '%{filter.MobileNo}%' ");
            if (!string.IsNullOrEmpty(filter.Email)) query.Append($"and EmailId like '%{filter.Email}%' ");
            if (filter.CreatedOn.HasValue) query.Append($"and date(Timestamp) = '{filter.CreatedOn.Value.ToString("yyyy/MM/dd")}' ");
            else
            {
                if (filter.CreatedFrom.HasValue) query.Append($"and date(Timestamp) > '{filter.CreatedFrom.Value.ToString("yyyy/MM/dd")}' ");
                if (filter.CreatedTo.HasValue) query.Append($"and date(Timestamp) < '{filter.CreatedTo.Value.ToString("yyyy/MM/dd")}' ");
            }
            query.Append(";");
            var report= dbContext.GetList<WorkOrderView>(query.ToString());
            return report;
        }

        public IEnumerable<PaymentReportView> GetFilteredPayments(PaymentReportFilter filter)
        {
            try
            {
                var query = new StringBuilder(WorkOrderQueries.GetCustomerPayments);
                query.Append(" where 1=1 ");
                if (!string.IsNullOrEmpty(filter.CustomerName)) query.Append($"and BP.Name like '%{filter.CustomerName}%' ");
                if (!string.IsNullOrEmpty(filter.ContactName)) query.Append($"and BPC.Name like '%{filter.ContactName}%' ");
                if (filter.Date.HasValue) query.Append($"and date(P.Timestamp) = '{filter.Date.Value.ToString("yyyy/MM/dd")}' ");
                else
                {
                    if (filter.DateFrom.HasValue) query.Append($"and date(P.Timestamp) >= '{filter.DateFrom.Value.ToString("yyyy/MM/dd")}' ");
                    if (filter.DateTo.HasValue) query.Append($"and date(P.Timestamp) <= '{filter.DateTo.Value.ToString("yyyy/MM/dd")}' ");
                }
                query.Append("order by P.Timestamp;");
                var report = dbContext.GetList<PaymentReportView>(query.ToString());
                
                return report;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }


        public bool UpdateWorkOrderItems(APIEmpIdModel<WorkOrderItemsUpdateModel> model)
        {
            try
            {
                var queries = new List<QueryWithParameters>();
                var queryUpdateWorkOrderItem = WorkOrderQueries.UpdateInvoiceItems;
                var WorkOrderId = model.Model.Items.FirstOrDefault().WorkOrderId;
                foreach (var item in model.Model.Items)
                {
                    if (item.Id == 0) dbContext.ExecuteNonQuery(WorkOrderQueries.AddInvoiceItem, DataHelper.ExtractParameters(item));
                    else dbContext.ExecuteNonQuery(queryUpdateWorkOrderItem, DataHelper.ExtractParameters(item));
                }
                foreach (var item in model.Model.DeletedItems)
                {
                    dbContext.ExecuteNonQuery(WorkOrderQueries.DeleteWorkOrderItem, DataHelper.ExtractParameters(item));
                }
                var updateQuery = WorkOrderQueries.UpdateWorkOrderInvoiceAmount;
                var updateParams = DataHelper.ExtractParameters(new { TotalAmount = model.Model.TotalAmount, Discount = model.Model.Discount, WorkOrderId = WorkOrderId });

                dbContext.ExecuteNonQuery(updateQuery, updateParams);

                var erpEvent = new ERPEventHelper().GetEventModel(model.EmployeeId, WorkOrderId, EventTypes.InvoiceUpdate);
                dbContext.ExecuteNonQuery(EventQueries.EventInsert, DataHelper.ExtractParameters(erpEvent));

                return true;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}