using ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.API.Data
{
    public class ERPEventHelper
    {
        public ERPEvent GetEventModel(int employeeId,int eventId,EventTypes eventTypeId)
        {
            return new ERPEvent() { EmployeeId = employeeId, EventId = eventId, EventTypeId = eventTypeId };
        }
    }

}
