using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Models.Views
{
    public class MaterialsView: Materials
    {
        
        public int AddedById { get; set; }
        public string AddedByName { get; set; }
        public DateTime Timestamp { get; set; }


    }
}
