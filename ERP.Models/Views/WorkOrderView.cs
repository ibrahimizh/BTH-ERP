using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Models.Views
{
    public class WorkOrderView:WorkOrder
    {
        public string Name { get; set; }

        public string PointofContact { get; set; }

        public string MobileNo { get; set; }

        public string EmailId { get; set; }

        public string Address { get; set; }
    }
}
