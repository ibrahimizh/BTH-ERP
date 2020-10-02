using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Models.Views
{
    public class SupplierPaymentReport
    {
        public int Id { get; set; }
        public int PurchaseOrderId { get; set; }
        public byte PaymentTypeId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Timestamp { get; set; }
        public string InvoiceNumber { get; set; }
        public string SupplierName { get; set; }
        public string PaymentType { get; set; }
        public string InvoiceNo { get; set; }
    }
}
