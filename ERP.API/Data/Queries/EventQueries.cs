using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.API.Data.Queries
{
    public static class EventQueries
    {
        public static readonly string EventInsert= @"INSERT INTO `erp`.`events`
                                                    (`EventTypeId`,
                                                    `EventId`,
                                                    `EmployeeId`,
                                                    `Timestamp`)
                                                    VALUES
                                                    (
                                                    @EventTypeId,
                                                    @EventId,
                                                    @EmployeeId,
                                                    now());";

        public static readonly string GetEvents = @"SELECT ev.*,concat(emp.firstname,' ',emp.lastname) as AddedBy, et.name as EventType FROM erp.events ev 
join erp.employees emp
on ev.employeeid= emp.id
join erp.event_types et
on ev.eventtypeid= et.id
where ev.eventid= @EventId and EventTypeId in (@EventTypes) order by ev.timestamp;
                                                ";
        public static readonly string GetPurchaseOrderEvents = @"SELECT ev.*,concat(emp.firstname,' ',emp.lastname) as AddedBy, et.name as EventType FROM erp.events ev 
join erp.employees emp
on ev.employeeid= emp.id
join erp.event_types et
on ev.eventtypeid= et.id
where ev.eventid= @EventId and EventTypeId in (10,11,12) order by ev.timestamp;
                                                ";
        public static readonly string GetEnquiryEvents = @"SELECT ev.*,concat(emp.firstname,' ',emp.lastname) as AddedBy, et.name as EventType FROM erp.events ev 
        join erp.employees emp
        on ev.employeeid= emp.id
        join erp.event_types et
        on ev.eventtypeid= et.id
        where ev.eventid= @EventId and EventTypeId in (1,2) order by ev.timestamp;";

        public static readonly string GetWorkOrderEvents = @"SELECT ev.*,concat(emp.firstname,' ',emp.lastname) as AddedBy, et.name as EventType FROM erp.events ev 
        join erp.employees emp
        on ev.employeeid= emp.id
        join erp.event_types et
        on ev.eventtypeid= et.id
        where ev.eventid= @EventId and EventTypeId in (3,4,5,6,7,14,15,16) order by ev.timestamp;";
    }
}
