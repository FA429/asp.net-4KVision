namespace sda_onsite_2_csharp_backend_teamwork.src.DTOs
{
    public class CheckoutDto
    {
        public Guid UserId { get; set; }

        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        public double TotalPrice { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }

    }
}