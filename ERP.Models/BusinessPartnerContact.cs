using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ERP.Models
{
    public class BusinessPartnerContact
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string ContactNo { get; set; }

        public string Email { get; set; }

        public int BusinessPartnerId { get; set; }

    }
}
