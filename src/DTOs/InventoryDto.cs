namespace sda_onsite_2_csharp_backend_teamwork.src.DTOs
{
    public class InventoryCreateDto
    {
        public Guid ProductId { get; set; }
        public string Quantity { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
    }
}