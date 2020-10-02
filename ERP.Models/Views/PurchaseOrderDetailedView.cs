using System;
using System.Collections.Generic;

namespace ERP.Models
{
    public class PurchaseOrderDetailedView:PurchaseOrderSimpleView
    {
        public IEnumerable<PurchaseOrderItemView> Items{get;set;}
        public bool PartiallyReceived{get;set;}
        
    }
}