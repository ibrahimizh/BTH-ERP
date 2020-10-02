namespace ERP.Models
{
    public class PurchaseOrderItem
    {
        public long Id { get; set; }
        public int PurchaseOrderId { get; set; }
        public int MaterialId { get; set; }
        public decimal OrderedQuantity { get; set; }
        public decimal ReceivedQuantity { get; set; }
        public string InvoiceNumber { get; set; }

    }
}