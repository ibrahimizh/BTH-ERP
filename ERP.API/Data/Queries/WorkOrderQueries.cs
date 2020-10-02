namespace ERP.API.Data.Queries
{
    public static class WorkOrderQueries
    {
        public static readonly string GetAll="select * from work_orders order by Timestamp desc;";

        public static readonly string GetById="select * from work_orders  where Id = @Id;";

        public static readonly string Add= @"INSERT INTO `work_orders`
                                            (
                                            `Title`,
                                            `ProposalId`,
                                            `Timestamp`,
                                            `StatusId`,
                                            `Description`,
                                            `TargetDate`,
                                            `InvoicedAmount`,
                                            `BusinessPartnerId`,
                                            `BusinessPartnerContactId`,
                                            `VAT`
                                            )
                                            VALUES
                                            (
                                            @Title, @ProposalId, now(), 1,@Description,@TargetDate,@InvoicedAmount,@BusinessPartnerId,@BusinessPartnerContactId,@VAT
                                            );
                                            SELECT LAST_INSERT_ID();";

        public static readonly string UpdateStatus=@"update work_orders set StatusId=@StatusId where Id=@Id;";

        public static readonly string CreateTask= @"INSERT INTO work_order_tasks
                                                    (
                                                    WorkOrderId,
                                                    EmployeeId,
                                                    Description,
                                                    StatusId,
                                                    Timestamp,
                                                    TargetDate,
                                                    Progress,
                                                    WorkOrderItemId)
                                                    VALUES
                                                    (
                                                    @WorkOrderId,
                                                    @EmployeeId,
                                                    @Description,
                                                    1,
                                                    now(),
                                                    @TargetDate,
                                                    0,@WorkOrderItemId
                                                    );SELECT LAST_INSERT_ID();";

        public static readonly string SelectAllTasks = @"select 
                                                    T.Id, T.WorkOrderId, EmployeeId, CONCAT(E.FirstName, ' ', E.LastName) AS 'EmployeeName', Description, StatusId, Timestamp, TargetDate, Progress, CompletedDate
                                                    , case when t.CompletedDate is null then datediff(now(),t.targetdate)
                                                    else datediff(t.completeddate,t.targetdate) end as OverdueDays
                                                    , case when t.CompletedDate is null then now()>t.targetdate
                                                    else t.CompletedDate>t.targetdate end as IsOverdue
                                                    , I.Id as WorkOrderItemId,I.Item,I.Specification 
                                                     from work_order_tasks T
                                                    inner join employees E
                                                    on T.EmployeeId=E.Id
                                                    left join work_order_items I
                                                    on T.WorkOrderItemId=I.Id order by I.Id desc;";

        public static readonly string SelectFilteredTasks = @"select 
                                                    T.Id, T.WorkOrderId, EmployeeId, CONCAT(E.FirstName, ' ', E.LastName) AS 'EmployeeName', Description, StatusId, Timestamp, TargetDate, Progress, CompletedDate
                                                    , case when t.CompletedDate is null then datediff(now(),t.targetdate)
                                                    else datediff(t.completeddate,t.targetdate) end as OverdueDays
                                                    , case when t.CompletedDate is null then now()>t.targetdate
                                                    else t.CompletedDate>t.targetdate end as IsOverdue
                                                    , I.Id as WorkOrderItemId,I.Item,I.Specification 
                                                     from `erp`.work_order_tasks T
                                                    inner join `erp`.employees E
                                                    on T.EmployeeId=E.Id
                                                    left join `erp`.work_order_items I
                                                    on T.WorkOrderItemId=I.Id where 1=1";

        public static readonly string SelectTasks= @"select 
                                                    T.Id, T.WorkOrderId, EmployeeId, CONCAT(E.FirstName, ' ', E.LastName) AS 'EmployeeName', Description, StatusId, Timestamp, TargetDate, Progress, CompletedDate
                                                    , case when t.CompletedDate is null then datediff(now(),t.targetdate)
                                                    else datediff(t.completeddate,t.targetdate) end as OverdueDays
                                                    , case when t.CompletedDate is null then now()>t.targetdate
                                                    else t.CompletedDate>t.targetdate end as IsOverdue
                                                    , I.Id as WorkOrderItemId,I.Item,I.Specification 
                                                     from work_order_tasks T
                                                    inner join employees E
                                                    on T.EmployeeId=E.Id
                                                    left join work_order_items I
                                                    on T.WorkOrderItemId=I.Id
                                                    where T.WorkOrderId=@Id;";

        public static readonly string SelectTaskById= @"select 
                                                    T.Id, T.WorkOrderId, EmployeeId, CONCAT(E.FirstName, ' ', E.LastName) AS 'EmployeeName', Description, StatusId, Timestamp, TargetDate, Progress, CompletedDate, I.Id as WorkOrderItemId,I.Item,I.Specification 
                                                     from work_order_tasks T
                                                    inner join employees E
                                                    on T.EmployeeId=E.Id
                                                    left join work_order_items I
                                                    on T.WorkOrderItemId=I.Id
                                                    where T.Id=@Id;";

        public static readonly string UpdateTask=@"update work_order_tasks
                                                   set StatusId=@StatusId,
                                                   Progress=@Progress
                                                   where Id=@Id;";

        public static readonly string StartTask=@"update work_order_tasks
                                                   set StartedDate=now(),StatusId=2
                                                   where Id=@Id;";

        public static readonly string EndTask=@"update work_order_tasks
                                                   set CompletedDate=@CompletedDate,StatusId=3
                                                   where Id=@Id;";


        public static readonly string AddMaterialUse=@"START TRANSACTION;

                                                        INSERT INTO materials_usage
                                                        (
                                                        MaterialId,
                                                        Units,
                                                        WorkOrderId,
                                                        Timestamp)
                                                        VALUES
                                                        (
                                                        @MaterialId, @Units, @WorkOrderId, now()
                                                        );

                                                        UPDATE materials
                                                        SET

                                                        Quantity = Quantity-@Units
                                                        WHERE Id = @MaterialId;


                                                        COMMIT;";

        public static readonly string SelectMaterialsUsed=@"SELECT U.*,M.Name AS Material FROM materials_usage U
                                                            INNER JOIN materials M
                                                            ON U.MaterialId=M.Id WHERE U.WorkOrderId=@WorkOrderId;
                                                            ";

        public static readonly string InsertCustomerPayment= @"START TRANSACTION;
        
                                                            INSERT INTO customer_payments
                                                            (
                                                            Amount,
                                                            WorkOrderId,
                                                            Timestamp,
                                                            PaymentTypeId,ReceiptNumber)
                                                            VALUES
                                                            (
                                                            @Amount,
                                                            @WorkOrderId,
                                                            now(),
                                                            @PaymentTypeId,@ReceiptNumber);
                                                            
                                                            UPDATE work_orders 
                                                            SET PaidAmount = PaidAmount + @Amount where Id=@WorkOrderId;
                                                            
                                                            COMMIT;";

        public static readonly string SelectCustomerPayments=@"SELECT * from v_customer_payments where WorkOrderId=@WorkOrderId;";

        public static readonly string AddInvoiceItem = @"START TRANSACTION;

                                                        INSERT INTO `erp`.`work_order_items`
                                                        (
                                                        `WorkOrderId`,
                                                        `Item`,
                                                        `Specification`,
                                                        `Quantity`,
                                                        `UnitPrice`)
                                                        VALUES
                                                        (
                                                        @WorkOrderId,
                                                        @Item,
                                                        @Specification,
                                                        @Quantity,
                                                        @UnitPrice);

                                                        UPDATE `erp`.`work_orders` SET TotalAmount=TotalAmount+(@Quantity*@UnitPrice) Where Id=@WorkOrderId;



                                                        COMMIT;
                                                        SELECT TotalAmount FROM `erp`.`work_orders` WHERE Id=@WorkOrderId;
                                                        ";
        public static readonly string GetInvoiceItems = @"select w.Discount,wi.*,(wi.Quantity * wi.UnitPrice) LineTotal,w.VAT from `erp`.work_order_items wi
                                                        left outer join `erp`.work_orders w
                                                        on wi.workorderid=w.id
                                                        where wi.workorderid=@Workorderid;";

        public static readonly string SetDiscount = "UPDATE `erp`.work_orders SET Discount=@Discount WHERE Id=@WorkOrderId;";
        public static readonly string SetCustomerPONumber = "UPDATE `erp`.work_orders SET CustomerPONumber=@CustomerPONumber WHERE Id=@WorkOrderId;";
        public static readonly string CopyItemsFromProposal = @"INSERT INTO  `erp`.`work_order_items`
                                                                (WorkOrderId, Item, Specification, Quantity, UnitPrice)
                                                                SELECT @WorkOrderId, Item, Specification, Quantity, UnitPrice 
                                                                FROM `erp`.`proposal_items` WHERE ProposalId=@ProposalId;";

        public static readonly string UpdateInvoiceItems = @"UPDATE `erp`.`work_order_items`
                                                        SET 
                                                        `Item`=@Item,
                                                        `Specification`=@Specification,
                                                        `Quantity`=@Quantity,
                                                        `UnitPrice`=@UnitPrice WHERE Id=@Id;";

        public static readonly string UpdateWorkOrderInvoiceAmount = @"UPDATE `erp`.`work_orders` SET TotalAmount=@TotalAmount,InvoicedAmount=@TotalAmount,Discount=@Discount 
                                                        Where Id = @WorkOrderId;";
        public static readonly string DeleteWorkOrderItem = @"DELETE FROM `erp`.`work_order_items` where Id=@Id";

        public static readonly string GetCustomerPayments = @"select 
Amount, P.WorkOrderId, P.Timestamp Date, PaymentTypeId, PO.Name PaymentType, ReceiptNumber, BP.Name CustomerName, BPC.Name ContactName, BPC.ContactNo MobileNo
 from `erp`.customer_payments P
inner join `erp`.payment_options PO on P.PaymentTypeId=PO.Id
inner join `erp`.work_orders W on P.workorderid=W.Id
left join `erp`.business_partners BP on W.BusinessPartnerId=BP.Id
left join `erp`.business_partner_contacts BPC on W.BusinessPartnerContactId=BPC.Id
";
    }
}