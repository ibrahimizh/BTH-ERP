using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.API.Data.Queries
{
    public static class SupplierQueries
    {
        public static readonly string Insert = @"INSERT INTO `erp`.`suppliers`
                                                (
                                                `Name`,`PointofContact`,`MobileNo`,`EmailId`,`Address`)
                                                VALUES
                                                (
                                                @Name,@PointofContact,@MobileNo,@EmailId,@Address);
                                                SELECT LAST_INSERT_ID();
                                                ";
        public static readonly string SelectAllWithEvents = @"select m.*,e.Timestamp,e.EmployeeId as AddedById, 
                                                            concat(emp.FirstName,' ',emp.lastname) as AddedByName from 
                                                            erp.suppliers m left join erp.events e on m.id=e.eventid 
                                                            left join erp.employees emp on e.employeeid= emp.id;";
    }
}
