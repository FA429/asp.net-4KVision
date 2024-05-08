using System.ComponentModel.DataAnnotations;

namespace sda_onsite_2_csharp_backend_teamwork.src.Entities
{
    public class Inventory
    {
        public Guid Id { get; set; }
        [Required]
        public Guid ProductId { get; set; } // Foreign key
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string Size { get; set; }
        public List<OrderItem>? OrderItem { get; set; } // Navigation Property
    }
}