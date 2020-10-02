using ERP.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Models.Views
{
    public class PaymentReportFilter
    {
        public DateTime? Date { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public decimal? AmountFrom { get; set; }
        public decimal? AmountTo { get; set; }
        public string CustomerName { get; set; }
        public string ContactName { get; set; }
        public string MobileNo { get; set; }
        public byte PaymentTypeId { get; set; }


    }
}
