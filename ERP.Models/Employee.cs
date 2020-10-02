using System;
using System.ComponentModel.DataAnnotations;

namespace ERP.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }      
        [Required]  
        public DateTime DateOfBirth { get; set; }
        public byte Gender { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public int? NationalityId { get; set; }
        public int? CurrencyId { get; set; }
        public int? BankId { get; set; }
        public string ABARouting { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string EndReason { get; set; }
        public int? EmployeeTypeId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

    }
}