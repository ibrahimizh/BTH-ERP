using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Models.Views
{
    public class QuoteView
    {
        public IEnumerable<ProposalItemView> Items { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal VAT { get; set; }
        public decimal Total { get; set; }

    }

    public class QuoteDiscountView
    {
        public int ProposalId { get; set; }
        public decimal Discount { get; set; }

    }

}
