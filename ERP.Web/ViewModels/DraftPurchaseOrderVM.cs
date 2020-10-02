using System.Collections.Generic;
using ERP.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

public class DraftPurchaseOrderVM
{
    public IEnumerable<SelectListItem> Suppliers { get; set; }
    public IEnumerable<SelectListItem> Materials { get; set; }
    public PurchaseOrderDetailedView DraftOrder{get;set;}

}