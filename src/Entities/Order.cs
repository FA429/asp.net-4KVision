

namespace sda_onsite_2_csharp_backend_teamwork.src.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; } // Foreign key
        public DateTime Date { get; set; } = DateTime.Now;
        public List<OrderItem>? OrderItem { get; set; } // Navigation Property

    }
}