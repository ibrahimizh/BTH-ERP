using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Models
{
    public class ERPEvent
    {
        public int Id { get; set; }
        public EventTypes EventTypeId { get; set; }
        public int EventId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Timestamp { get; set; }

    }
}
