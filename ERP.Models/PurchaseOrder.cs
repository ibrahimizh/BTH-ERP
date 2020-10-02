using System;

namespace ERP.Models
{
    public class PurchaseOrder
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }        
        public int SupplierId { get; set; }
        public DateTime? OrderedDate { get; set; }
        public byte StatusId { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public Decimal? TotalAmount { get; set; }
        public Decimal? TotalAmountWithTax { get; set; }
        public Decimal? AmountPaid { get; set; }
        public string InvoiceNumber { get; set; }


    }
}