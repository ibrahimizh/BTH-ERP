using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Models.Views
{
    public class InvoiceView
    {
        public IEnumerable<WorkOrderItemView> Items { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal VAT { get; set; }
        public decimal Total { get; set; }

    }

    public class DiscountView
    {
        public int WorkOrderId { get; set; }
        public decimal Discount { get; set; }

    }

    public class CustomerPONumberView
    {
        public int WorkOrderId { get; set; }
        public string CustomerPONumber { get; set; }
    }
}
