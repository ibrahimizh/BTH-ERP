using System;
using System.ComponentModel.DataAnnotations;

namespace ERP.Models
{
    public class Proposal
    {
        public int Id { get; set; }
        [Required]
        public string  Description { get; set; }
        public DateTime Timestamp { get; set; }
        [Required(ErrorMessage="Select Mode of Contact")]
        public ProposalContactTypes ContactMode { get; set; }
        //[Required]
        //public string ContactPerson { get; set; }
        //public string Address { get; set; }
        //public string Phone { get; set; }
        //public string Email { get; set; }
        public int? WorkOrderId { get; set; }
        public int? BusinessPartnerId { get; set; }

        public int? BusinessPartnerContactId { get; set; }
        public decimal? Discount { get; set; }
        public decimal? TotalAmount { get; set; }
        public int QuoteRevisionNo { get; set; }
        public byte VAT { get; set; }

    }
}