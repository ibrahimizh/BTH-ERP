using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Models
{
    public class ProposalItems
    {
        public int Id { get; set; }
        public int ProposalId { get; set; }
        public string Item { get; set; }
        public string Specification { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }


    }

    public class ProposalItemView : ProposalItems
    {
        public decimal LineTotal { get; set; }
        public decimal Discount { get; set; }
        public byte VAT { get; set; }

    }
}
