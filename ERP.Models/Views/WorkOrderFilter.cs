using ERP.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Models.Views
{
    public class WorkOrderFilter
    {
        public string Title { get; set; }
        public WorkOrderStatus? StatusId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? CreatedFrom { get; set; }
        public DateTime? CreatedTo { get; set; }
        public DateTime? TargetDateFrom { get; set; }
        public DateTime? TargetDateTo { get; set; }
        public DateTime? StartDateFrom { get; set; }
        public DateTime? StartDateTo { get; set; }
        public DateTime? EndDateFrom { get; set; }
        public DateTime? EndDateTo { get; set; }
        public decimal? InvoicedAmountFrom { get; set; }
        public decimal? PaidAmountFrom { get; set; }
        public decimal? InvoicedAmountTo { get; set; }
        public decimal? PaidAmountTo { get; set; }
        public string CustomerName { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }



    }
}
