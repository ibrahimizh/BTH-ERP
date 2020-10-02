using System.Collections.Generic;
using ERP.Models;

namespace ERP.Web.ViewModels
{
    public class AllPurchaseOrdersVM
    {
        public IEnumerable<PurchaseOrderSimpleView> DraftOrders { get; set; }
        public IEnumerable<PurchaseOrderSimpleView> ConfirmedOrders { get; set; }
        public IEnumerable<PurchaseOrderSimpleView> ReceivedOrders { get; set; }

    }
}