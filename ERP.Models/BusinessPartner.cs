using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ERP.Models
{
    public class BusinessPartnerType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class BusinessPartner
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string PointofContact { get; set; }

        public string MobileNo { get; set; }

        public string EmailId { get; set; }

        public string Address { get; set; }

        public int BusinessPartnerTypeId { get; set; }

        public string VATNo { get; set; }


    }

    public class BusinessPartnerViewModel:BusinessPartner
    {
        public List<BusinessPartnerContact> Contacts { get; set; }

    }
}
