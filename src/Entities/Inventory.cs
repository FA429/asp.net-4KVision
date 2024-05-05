namespace sda_onsite_2_csharp_backend_teamwork.src.Entities
{
    public class Inventory
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string Quantity { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public List<OrderItem>? OrderItem { get; set; }
    }
}