using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Models
{
    public class WorkOrderItems
    {
        public int Id { get; set; }
        public int WorkOrderId { get; set; }
        public string Item { get; set; }
        public string Specification { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }


    }

    public class WorkOrderItemView : WorkOrderItems
    {
        public decimal LineTotal { get; set; }
        public decimal Discount { get; set; }
        public byte VAT { get; set; }
    }

    public class WorkOrderItemsUpdateModel
    {
        public List<WorkOrderItems> Items { get; set; }
        public List<WorkOrderItems> DeletedItems { get; set; }
        public decimal? Discount { get; set; }
        public decimal VAT { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
