using System.ComponentModel.DataAnnotations;


namespace ERP.Models
{
    public class Suppliers
    {
        public int Id { get; set; }

        [Required] 
        public string  Name { get; set; }
       
        public string PointofContact { get; set; }
      
        public string MobileNo { get; set; }
       
        public string EmailId { get; set; } 
         
        public string Address { get; set; }  
        
         
           
    }
}