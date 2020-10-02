using ERP.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Models.Views
{
    public class SupplierPaymentReportFilter
    {
        public DateTime? Date { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public decimal? AmountFrom { get; set; }
        public decimal? AmountTo { get; set; }
        public string SupplierName { get; set; }
        public byte PaymentTypeId { get; set; }


    }
}
