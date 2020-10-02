namespace ERP.API.Data.Queries
{
    public static class MaterialsQueries
    {
        public static readonly string UpdateQuantity=@"update materials set Quantity = Quantity+@ReceivedQuantity  where Id = @Id;";
        public static readonly string UpdateQuantityProcedure="Update_Materials_Quantity";
        public static readonly string Update = @"UPDATE `erp`.`materials`
                                                SET
                                                `Code` = @Code,
                                                `Name` = @Name,
                                                `Specification` = @Specification,
                                                `ShelfNumber` = @ShelfNumber
                                                WHERE `Id` = @Id;
                                                ";
        public static readonly string Insert = @"insert into erp.materials 
                                                (code,name,specification,quantity,shelfnumber) 
                                                values (@Code,@Name,@Specification,0,@ShelfNumber);SELECT LAST_INSERT_ID();";

        public static readonly string SelectAllWithEvents = @"select m.*,e.Timestamp,e.EmployeeId as AddedById, 
                                                            concat(emp.FirstName,' ',emp.lastname) as AddedByName from 
                                                            erp.materials m left join erp.events e on m.id=e.eventid 
                                                            left join erp.employees emp on e.employeeid= emp.id;";



    }
}