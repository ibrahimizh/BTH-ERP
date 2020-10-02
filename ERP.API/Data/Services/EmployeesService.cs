using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Dapper;
using ERP.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ERP.API.Data.Services
{
    public interface IEmployeesService
    {
        int Add(Employee newEmployee);
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        IEnumerable<SelectListItem> GetDropDown();
        //EmployeeFeaturesViewModel GetFeatures(int id);
        bool Authenticate(string username, string password);
    }
    public class EmployeesService : IEmployeesService
    {
        private IDbContext dbContext;

        public EmployeesService(IDbContext dbContext)
        {
            this.dbContext=dbContext;
        }
        public int Add(Employee newEmployee)
        {
            //  var queryBuilder=new StringBuilder()
            //                 .Append("INSERT INTO `employees` ")
            //                 .Append("(`FirstName`,`LastName`,`DateOfBirth`,`Gender`,`MobileNo`, ")
            //                 .Append("`Email`,`Address`,`CountryId`,`CityId`,`NationalityId`,`CurrencyId`, ")
            //                 .Append("`BankId`,`ABARouting`,`StartDate`,`EndDate`,`EndReason`,`EmployeeTypeId`) ")
            //                 .Append($"VALUES ('{ newEmployee.FirstName }','{ newEmployee.LastName }', ")
            //                 .Append($"'{ newEmployee.DateOfBirth.ToString("yyyy-MM-dd") }',{ newEmployee.Gender },'{ newEmployee.MobileNo }', ")
            //                 .Append($"'{ newEmployee.Email }','{ newEmployee.Address }',{ newEmployee.CountryId }, ")
            //                 .Append($"{ newEmployee.CityId },{ newEmployee.NationalityId },{ newEmployee.CurrencyId }, ")
            //                 .Append($"{ newEmployee.BankId },'{ newEmployee.ABARouting }','{ newEmployee.StartDate }', ")
            //                 .Append($"'{ newEmployee.EndDate }','{ newEmployee.EndReason }',{ newEmployee.EmployeeTypeId }); ")
            //                 .Append("SELECT LAST_INSERT_ID();")
            //                 ;

            if(newEmployee.StartDate==DateTime.MinValue)newEmployee.StartDate=null;
            if(newEmployee.EndDate==DateTime.MinValue)newEmployee.EndDate=null;

            // var queryBuilder=new StringBuilder()
            //                 .Append("INSERT INTO employees ")
            //                 .Append("(FirstName,LastName,DateOfBirth,Gender,MobileNo, ")
            //                 .Append("Email,Address,CountryId,CityId,NationalityId,CurrencyId, ")
            //                 .Append("BankId,ABARouting,StartDate,EndDate,EndReason,EmployeeTypeId) ")
            //                 .Append("VALUES (@FirstName,@LastName, ")
            //                 .Append("@DateOfBirth, @Gender ,@MobileNo, ")
            //                 .Append("@Email,@Address,@CountryId , ")
            //                 .Append("@CityId ,@NationalityId ,@CurrencyId , ")
            //                 .Append("@BankId ,@ABARouting,@StartDate, ")
            //                 .Append("@EndDate,@EndReason,@EmployeeTypeId ); ")
            //                 .Append("SELECT LAST_INSERT_ID();")
            //                 ;

            
            // var parameters=new DynamicParameters();
            // Type type=typeof(Employee);
            // PropertyInfo[] properties = type.GetProperties();
            // foreach (PropertyInfo property in properties)
            // {
            //     parameters.Add(property.Name,property.GetValue(newEmployee, null));
            // }
            
            var parameters=DataHelper.ExtractParameters(newEmployee);

            // var query=queryBuilder.ToString();
            var query=EmployeeQueries.Insert;
            return dbContext.Execute<int>(query,parameters);
        }

        public IEnumerable<Employee> GetAll()
        {
            // var query="select * from employees;";
            var query=EmployeeQueries.SelectAll;
            return dbContext.GetList<Employee>(query);
        }

        public IEnumerable<SelectListItem> GetDropDown()
        {
            var query=EmployeeQueries.SelectAll;
            var employees= dbContext.GetList<Employee>(query).ToList();
            return employees.Select(x=>new SelectListItem{
                Text=x.FirstName+" "+x.LastName,
                Value=x.Id.ToString()
            }).ToList();
        }

        public Employee GetById(int id){
            var query=EmployeeQueries.SelectById;
            var parameters=DataHelper.ExtractParameters(new {Id=id});
            var employee=dbContext.Get<Employee>(query,parameters);
            return employee;
        }

        //public EmployeeFeaturesViewModel GetFeatures(int id)
        //{
        //    var query = EmployeeQueries.SelectEmployeeFeatures;
        //    var parameters = DataHelper.ExtractParameters(new { EmployeeId = id });
        //    var employeeFeatures = dbContext.GetList<SelectFeature>(query, parameters);
        //    var employeeFeaturesViewModel = new EmployeeFeaturesViewModel() { EmployeeId = id, Features = employeeFeatures };
        //    return employeeFeaturesViewModel;

        //}

        public bool Authenticate(string username, string password)
        {
            var query = EmployeeQueries.VerifyCredentials;
            var parameters = DataHelper.ExtractParameters(new { username = username,password=password });
            var employeeId = dbContext.GetList<int>(query, parameters);
            return (employeeId.Count()==0) ? false : true;
        }

        public bool UpdatePassword(string password, int id)
        {
            var query = EmployeeQueries.ChangePassword;
            var parameters = DataHelper.ExtractParameters(new {password,id });
            dbContext.ExecuteNonQuery(query, parameters);
            return true;
        }
    }
}