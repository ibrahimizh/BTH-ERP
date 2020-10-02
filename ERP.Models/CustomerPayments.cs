using System;

namespace ERP.Models
{
    public class CustomerPayments
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }        
        public int WorkOrderId { get; set; }
        public PaymentOptions PaymentTypeId { get; set; }
        public Decimal Amount { get; set; }
        public string ReceiptNumber { get; set; }


    }
}