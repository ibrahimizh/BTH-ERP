using System.ComponentModel.DataAnnotations;

namespace ERP.Models
{
    public class Materials
    {
        public int Id { get; set; }
        [Required]
        public string  Code { get; set; }
        [Required]
        public string Name { get; set; }
        public string Specification { get; set; }   
        public decimal Quantity { get; set; }
        public string ShelfNumber { get; set; }

    }
}