namespace sda_onsite_2_csharp_backend_teamwork.src.DTOs
{
    public class CheckoutDto
    {
        public Guid InventoryId { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
    }
}