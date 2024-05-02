namespace sda_onsite_2_csharp_backend_teamwork.src.DTOs
{
    public class OrderItemCreateDto
    {
        public Guid InventoryId { get; set; }
        public Guid OrderId { get; set; }
        public string Quantity { get; set; }
        public string TotalPrice { get; set; }

    }
}