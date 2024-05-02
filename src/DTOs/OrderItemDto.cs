namespace sda_onsite_2_csharp_backend_teamwork.src.DTOs
{
    public class OrderItemCreateDto
    {
        public Guid Inventory_id { get; set; }
        public Guid Order_id { get; set; }
        public string Quantity { get; set; }
        public string Total_price { get; set; }

    }
}