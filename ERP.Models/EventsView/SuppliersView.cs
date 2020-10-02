using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Models.Views
{
    public class SuppliersView:Suppliers
    {
        public int AddedById { get; set; }
        public string AddedByName { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
