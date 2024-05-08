namespace sda_onsite_2_csharp_backend_teamwork.src.DTOs
{
    public class OrderItemCreateDto
    {
        public Guid InventoryId { get; set; }
        public Guid OrderId { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }

    }
}