using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Models.Views
{
    public class ERPeventView:ERPEvent
    {
        public string EventType { get; set; }

        public string AddedBy { get; set; }

    }
}
