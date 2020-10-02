using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;
using ERP.API.Data.Queries;
using ERP.Models;
using ERP.Models.Views;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ERP.API.Data.Services
{
    public class PurchaseOrderService
    {
        private IDbContext dbContext;

        public PurchaseOrderService(IDbContext dbContext)
        {
            this.dbContext=dbContext;
        }

        public IEnumerable<SelectListItem> GetStatusDropdown(){
            var query=PurchaseOrderQueries.SelectStatusDropDown;
            var statusList= dbContext.GetList<PurchaseOrderStatus>(query).ToList();
            return statusList.Select(x=>new SelectListItem{
                Text=x.Name,
                Value=x.Id.ToString()
            }).ToList();
        }

        public int InsertPurchaseOrderDraft(APIEmpIdModel<PurchaseOrderSimpleView> model){
            try
            {
                model.Model.CreatedDate = DateTime.Now;
                var query = PurchaseOrderQueries.InsertDraft;
                var parameters = DataHelper.ExtractParameters(new { SupplierId = model.Model.SupplierId });
                var purchaseOrderId= dbContext.Execute<int>(query, parameters);
                if (purchaseOrderId>0)
                {
                    var erpEvent = new ERPEventHelper().GetEventModel(model.EmployeeId, purchaseOrderId, EventTypes.PurchaseOrderCreate);
                    dbContext.ExecuteNonQuery(EventQueries.EventInsert, DataHelper.ExtractParameters(erpEvent));
                    return purchaseOrderId; 
                }
                else throw new System.Exception("Error adding Purchase Order!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        
        public IEnumerable<PurchaseOrderSimpleView> GetDraftOrders(){
            var query=PurchaseOrderQueries.SelectDraftOrders;
            return dbContext.GetList<PurchaseOrderSimpleView>(query);
        }

        public PurchaseOrderSimpleView GetDraftOrderById(int id)
        {
            var query=PurchaseOrderQueries.SelectPurchaseOrderViewById;
            var parameters=DataHelper.ExtractParameters(new{Id=id});
            return dbContext.Get<PurchaseOrderSimpleView>(query,parameters);
        }

        public long AddPurchaseOrderItem(PurchaseOrderItem item)
        {
            var query=PurchaseOrderQueries.InsertPurchaseOrderItem;
            var parameters=DataHelper.ExtractParameters(item);
            return dbContext.Execute<long>(query,parameters);
        }

        public bool RemovePurchaseOrderItem(long id)
        {
            // var query=PurchaseOrderQueries.DeletePurchaseOrderItem;
            // var parameters=DataHelper.ExtractParameters(new{Id=id});
            // dbContext.Execute(query,parameters);
            var query=$"DELETE FROM purchase_order_items WHERE Id={id}";
            dbContext.ExecuteNonQuery(query);
            return true;
        }

        public bool ConfirmPurchaseOrder(APIEmpIdModel<int> model)
        {
            var query=PurchaseOrderQueries.UpdatePurchaseOrderToConfirmed;
            var parameters=DataHelper.ExtractParameters(new{Id=model.Model});
            dbContext.ExecuteNonQuery(query,parameters);
            var erpEvent = new ERPEventHelper().GetEventModel(model.EmployeeId, model.Model, EventTypes.PurchaseOrderConfirm);
            dbContext.ExecuteNonQuery(EventQueries.EventInsert, DataHelper.ExtractParameters(erpEvent));
            return true;
        }

        public IEnumerable<PurchaseOrderItemView> GetPurchaseOrderItems(int id)
        {
            var query=PurchaseOrderQueries.SelectPurchaseOrderItemsByOrderId;
            var parameters=DataHelper.ExtractParameters(new{Id=id});
            return dbContext.GetList<PurchaseOrderItemView>(query,parameters);
        }

        public IEnumerable<PurchaseOrderSimpleView> GetConfirmedOrders(){
            var query=PurchaseOrderQueries.SelectConfirmedOrders;
            return dbContext.GetList<PurchaseOrderSimpleView>(query);
        }

        public PurchaseOrderSimpleView GetConfirmedOrderById(int id)
        {
            var query=PurchaseOrderQueries.SelectPurchaseOrderViewById;
            var parameters=DataHelper.ExtractParameters(new{Id=id});
            return dbContext.Get<PurchaseOrderSimpleView>(query,parameters);
        }
        
        
        public void SetPurchaseOrderReceiving(APIEmpIdModel<PurchaseOrderDetailedView> model)
        {

            var queries=new List<QueryWithParameters>();
            var updateItemsQuery=MaterialsQueries.UpdateQuantity;
            foreach(var item in model.Model.Items)
            {
                
                //Update PO Received Quantity
                var parametersRQ=DataHelper.ExtractParameters(new{item.ReceivedQuantity,item.Id});
                queries.Add(new QueryWithParameters(){Query=PurchaseOrderQueries.UpdatePurchaseOrderItemReceivedQuantity,Parameters=parametersRQ});

                //Update Materials Quantity
                var parameters=DataHelper.ExtractParameters(new{item.ReceivedQuantity,Id=item.MaterialId});
                queries.Add(new QueryWithParameters(){Query=updateItemsQuery,Parameters=parameters});
                
                // var parameters=new DynamicParameters();
                // parameters.Add("_Quantity",item.ReceivedQuantity,DbType.Int32,ParameterDirection.Input);
                // parameters.Add("_Id",item.Id,DbType.Int64,ParameterDirection.Input);
                // queries.Add(new QueryWithParameters(){Query=MaterialsQueries.UpdateQuantityProcedure,Parameters=parameters,IsProcedure=true});

                // var updateItemsCountQueryTemplate=MaterialsQueries.UpdateQuantity;
                // var updateItemsCountQuery=updateItemsCountQueryTemplate.Replace("@Quantity",item.ReceivedQuantity.ToString())
                //                      .Replace("@Id",item.Id.ToString());
                // queries.Add(new QueryWithParameters(){Query=updateItemsCountQuery,Parameters=null});

            }
            var queryUpdatePurchaseOrderStatusToReceive=PurchaseOrderQueries.UpdatePurchaseOrderToReceived;
            var status=(model.Model.PartiallyReceived)?4:5;
            var updateStatusParameters=DataHelper.ExtractParameters(new{ model.Model.ReceivedDate,StatusId = status,model.Model.TotalAmount,model.Model.InvoiceNumber,model.Model.Id});
            
            queries.Add(new QueryWithParameters(){Query=queryUpdatePurchaseOrderStatusToReceive,Parameters=updateStatusParameters});
            var erpEvent = new ERPEventHelper().GetEventModel(model.EmployeeId, model.Model.Id, EventTypes.PurchaseOrderReceive);
            queries.Add(new QueryWithParameters() { Query = EventQueries.EventInsert, Parameters = DataHelper.ExtractParameters(erpEvent) });
            dbContext.ExecuteTransaction(queries);
        }
        public IEnumerable<PurchaseOrderSimpleView> GetReceivedOrders(){
            var query=PurchaseOrderQueries.SelectReceivedOrders;
            return dbContext.GetList<PurchaseOrderSimpleView>(query);
        }
        public PurchaseOrderDetailedView GetReceivedOrderById(int id)
        {
            var query=PurchaseOrderQueries.SelectPurchaseOrderViewById;
            var parameters=DataHelper.ExtractParameters(new{Id=id});
            var receivedOrder= dbContext.Get<PurchaseOrderDetailedView>(query,parameters);
            receivedOrder.Items=GetPurchaseOrderItems(id);
            return receivedOrder;
        }

        public bool AddSupplierPayment(APIEmpIdModel<AddSupplierPaymentModel> model)
        {
            var queryAddPayment = PurchaseOrderQueries.InsertSupplierPayment;
            var parametersAddPayment = DataHelper.ExtractParameters(model.Model);
            var supplierPaymentId=dbContext.Execute<int>(queryAddPayment, parametersAddPayment);
            if (supplierPaymentId > 0)
            {
                var erpEvent = new ERPEventHelper().GetEventModel(model.EmployeeId, supplierPaymentId, EventTypes.SupplierPaymentAdd);
                dbContext.ExecuteNonQuery(EventQueries.EventInsert, DataHelper.ExtractParameters(erpEvent));
            }
            return true;
        }

        public IEnumerable<SupplierPaymentsView> GetSupplierPaymentsByPurchaseOrder(int purchaseOrderId)
        {
            var query = PurchaseOrderQueries.SelectSupplierPaymentsByPurchaseOrder;
            var parameters = DataHelper.ExtractParameters(new { PurchaseOrderId = purchaseOrderId });
            return dbContext.GetList<SupplierPaymentsView>(query,parameters);
        }

        public IEnumerable<SupplierPaymentReport> GetSupplierPaymentReport(SupplierPaymentReportFilter filter)
        {
            try
            {
                var query = new StringBuilder(PurchaseOrderQueries.SelectSupplierPaymentReport);
                query.Append(" where 1=1 ");
                if (filter.Date.HasValue) query.Append($"and date(Timestamp) = '{filter.Date.Value.ToString("yyyy/MM/dd")}' ");
                else
                {
                    if (filter.DateFrom.HasValue) query.Append($"and date(Timestamp) >= '{filter.DateFrom.Value.ToString("yyyy/MM/dd")}' ");
                    if (filter.DateTo.HasValue) query.Append($"and date(Timestamp) <= '{filter.DateTo.Value.ToString("yyyy/MM/dd")}' ");
                }
                query.Append("order by Timestamp;");
                var report= dbContext.GetList<SupplierPaymentReport>(query.ToString());
                return report;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}