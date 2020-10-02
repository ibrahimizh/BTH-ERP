using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Models
{
    public class APIEmpIdModel<T>
    {
        public int EmployeeId { get; set; }
        public T Model { get; set; }

    }
}
