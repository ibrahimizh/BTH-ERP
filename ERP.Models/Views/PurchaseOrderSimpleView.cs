using System;

namespace ERP.Models{
public class PurchaseOrderSimpleView
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public int SupplierId { get; set; }
    public string SupplierName { get; set; }
    public DateTime OrderedDate { get; set; }
    public byte StatusId { get; set; }
    public string Status { get; set; }
    public decimal TotalAmount{get;set;}
    public DateTime ReceivedDate { get; set; }
    public string InvoiceNumber { get; set; }
    public decimal PaidAmount { get; set; }
        public string AddedBy { get; set; }


    }
}