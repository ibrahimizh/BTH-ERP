using System;

namespace ERP.Models
{
    public class SupplierPayments
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }        
        public int PurchaseOrderId { get; set; }
        public PaymentOptions PaymentTypeId { get; set; }
        public Decimal Amount { get; set; }
        public string InvoiceNumber { get; set; }
    }
    public class AddSupplierPaymentModel
    {
        public int PurchaseOrderId { get; set; }
        public PaymentOptions PaymentTypeId { get; set; }
        public Decimal Amount { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime Timestamp { get; set; }

    }
    public class SupplierPaymentsView:SupplierPayments
    {
        public string AddedBy { get; set; }

    }
}