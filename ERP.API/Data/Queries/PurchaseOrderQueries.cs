namespace ERP.API.Data.Queries
{
    public static class PurchaseOrderQueries
    {
        public static readonly string SelectStatusDropDown="SELECT * FROM purchase_order_status;";
        //public static readonly string SelectAll="SELECT * FROM purchase_order_status;";
        public static readonly string InsertDraft=@"INSERT INTO purchase_orders
                                                            (
                                                            CreatedDate,
                                                            SupplierId,
                                                            StatusId)
                                                            VALUES
                                                            (
                                                            NOW(),
                                                            @SupplierId,
                                                            1);
                                                            SELECT LAST_INSERT_ID();";

        public static readonly string SelectDraftOrders=@"SELECT *
                                                            FROM V_DraftPurchaseOrders order by createddate desc;";

        public static readonly string SelectPurchaseOrderViewById=@"SELECT *
                                                                FROM V_PurchaseOrders
                                                                WHERE Id=@Id";

        public static readonly string InsertPurchaseOrderItem=@"INSERT INTO purchase_order_items
                                                                 (PurchaseOrderId,MaterialId,OrderedQuantity)
                                                                 VALUES (@PurchaseOrderId,@MaterialId,@OrderedQuantity);
                                                                 SELECT LAST_INSERT_ID();
                                                                 ";

        public static readonly string DeletePurchaseOrderItem=@"DELETE FROM purchase_order_items
                                                                 WHERE Id=@Id;
                                                                 ";

        public static readonly string SelectPurchaseOrderItems="SELECT * FROM v_purchase_order_items;";
        public static readonly string SelectPurchaseOrderItemsByOrderId="SELECT * FROM v_purchase_order_items WHERE PurchaseOrderId=@Id;";

        public static readonly string UpdatePurchaseOrderToConfirmed=@"UPDATE purchase_orders SET OrderedDate=Now(),StatusId=2 WHERE Id=@Id;";
        public static readonly string SelectConfirmedOrders=@"SELECT *
                                                            FROM v_confirmed_purchase_orders order by ordereddate desc;";

        public static readonly string UpdatePurchaseOrderToReceived= "UPDATE purchase_orders SET ReceivedDate=@ReceivedDate,StatusId=@StatusId,TotalAmount=@TotalAmount,InvoiceNumber=@InvoiceNumber WHERE Id=@Id;";
        
        public static readonly string UpdatePurchaseOrderItemReceivedQuantity="update purchase_order_items set ReceivedQuantity=@ReceivedQuantity where Id=@Id;";

        public static readonly string SelectReceivedOrders=@"SELECT *
                                                            FROM v_purchaseorders WHERE StatusId=4 OR StatusId=5 order by receiveddate desc;";

        public static readonly string InsertSupplierPayment = @"INSERT INTO `erp`.`supplier_payments`
                                                                (
                                                                `PurchaseOrderId`,
                                                                `PaymentTypeId`,
                                                                `Amount`,
                                                                `Timestamp`,
                                                                `InvoiceNumber`)
                                                                VALUES
                                                                (
                                                                @PurchaseOrderId,
                                                                @PaymentTypeId,
                                                                @Amount,
                                                                @Timestamp,
                                                                @InvoiceNumber);SELECT LAST_INSERT_ID();";

        public static readonly string SelectSupplierPaymentsByPurchaseOrder = @"SELECT p.*,concat(emp.firstname,' ',emp.lastname) as AddedBy FROM `erp`.`supplier_payments` p
join erp.events ev on p.id= ev.eventid
join erp.employees emp
on ev.employeeid= emp.id
 WHERE p.PurchaseOrderId= @PurchaseOrderId and ev.eventtypeid= 13;";

        public static readonly string SelectSupplierPaymentReport = @"select SP.*,S.Name 'SupplierName',P.Name 'PaymentType',PO.InvoiceNumber 'InvoiceNo' from  `erp`.`supplier_payments` SP
INNER JOIN `erp`.`purchase_orders` PO ON SP.PurchaseOrderId=PO.Id
INNER JOIN `erp`.`suppliers` S ON PO.SupplierId=S.Id
INNER JOIN `erp`.`payment_options` P ON SP.PaymentTypeId=P.Id
";
    }
}