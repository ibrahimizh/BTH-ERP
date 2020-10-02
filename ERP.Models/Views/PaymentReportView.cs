using ERP.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Models.Views
{
    public class PaymentReportView
    {
        //public PaymentReportView()
        //{
        //    if (this.Date != null) this.DateString = this.Date.ToShortDateString();
        //}
        public DateTime Date { get; set; }
        public string DateString { get { return this.Date.ToString("dd/MM/yyyy"); } }
        public decimal Amount { get; set; }
        public string CustomerName { get; set; }
        public string ContactName { get; set; }
        public string ContactDisplayName { get { return (string.IsNullOrEmpty(this.ContactName)) ? " - " : this.ContactName; } }
        public string MobileNo { get; set; }
        public byte PaymentTypeId { get; set; }
        public string PaymentType { get; set; }
        public int WorkOrderId { get; set; }
        public string ReceiptNumber { get; set; }
        //public void FormatDate()
        //{
        //    this.DateString = this.Date.ToShortDateString();
        //}
    }
    
    public class PaymentReportDetailedView
    {
        public IEnumerable<PaymentReportView> ReportData { get; set; }
        public decimal CashTotal { get; set; }
        public decimal ChequeTotal { get; set; }
        public decimal BankTransferTotal { get; set; }
        public decimal PointOfSaleTotal { get; set; }

    }
}
