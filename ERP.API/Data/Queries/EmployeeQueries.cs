public static class EmployeeQueries
{
    public static readonly string SelectAll="select * from employees;";
    public static readonly string SelectById="select * from employees where Id=@Id;";
    public static readonly string Insert=@"INSERT INTO employees
                                        (FirstName,LastName,DateOfBirth,Gender,MobileNo,
                                        Email,Address,CountryId,CityId,NationalityId,CurrencyId,
                                        BankId,ABARouting,StartDate,EndDate,EndReason,EmployeeTypeId)
                                        VALUES (@FirstName,@LastName,
                                        @DateOfBirth, @Gender ,@MobileNo,
                                        @Email,@Address,@CountryId ,
                                        @CityId ,@NationalityId ,@CurrencyId ,
                                        @BankId ,@ABARouting,@StartDate,
                                        @EndDate,@EndReason,@EmployeeTypeId );
                                        SELECT LAST_INSERT_ID();";
    public static readonly string SelectAllFeatures = "SELECT * FROM `erp`.`features` ;";
    public static readonly string InsertEmployeeFeatures = @"INSERT INTO `erp`.`employee_features`
                                                    (EmployeeId,FeatureId)
                                                    SELECT @EmployeeId,Id FROM `erp`.`features` WHERE Id IN (@FeatureIds);";
    public static readonly string DeleteEmployeeFeatures = @"DELETE FROM `erp`.`employee_features`
                                                    WHERE EmployeeId=@EmployeeId;
                                                    ";
    public static readonly string SelectEmployeeFeatures = @"select f.Id 'FeatureId',(case when sef.Id is null then false else true end) Selected from `erp`.`features` f left join 
                                                    (select Id,FeatureId from `erp`.`employee_features` WHERE EmployeeId=@EmployeeId) as sef
                                                    on f.Id=sef.FeatureId
                                                    order by f.Id;";

    public static readonly string VerifyCredentials = "select id from erp.employees where username=@username and password=@password;";

    public static readonly string ChangePassword = "update erp.employees set password=@password where Id=@Id;";
}