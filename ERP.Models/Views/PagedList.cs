using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Models.Views
{
    public class PagedList<T>
    {
        public IEnumerable<T> Data { get; set; }
        public int Count { get; set; }
        public int PageNumber { get; set; }
        public int TotalPages { get; set; }


    }
}
