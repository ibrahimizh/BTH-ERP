using System;
using System.ComponentModel.DataAnnotations;
using ERP.Models.Enums;

namespace ERP.Models
{
    public class WorkOrder
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int ProposalId { get; set; }
        public DateTime Timestamp { get; set; }
        public WorkOrderStatus StatusId { get; set; }
        public string Description { get; set; }
        public DateTime TargetDate { get; set; }
        public DateTime? StartedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public decimal? InvoicedAmount { get; set; }
        public decimal? PaidAmount { get; set; }
        public int? BusinessPartnerId { get; set; }
        public int? BusinessPartnerContactId { get; set; }
        public decimal? Discount { get; set; }
        public byte VAT { get; set; }
        public string CustomerPONumber { get; set; }

    }

    public class UpdateWorkOrderStatusModel
    {
        public int WorkOrderId { get; set; }
        public byte Status { get; set; }
        public DateTime Timestamp { get; set; }
        
    }
}