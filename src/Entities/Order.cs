

namespace sda_onsite_2_csharp_backend_teamwork.src.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public Guid ProductId { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public IEnumerable<OrderItem>? OrderItem { get; set; }

    }
}