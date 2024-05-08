namespace sda_onsite_2_csharp_backend_teamwork.src.DTOs
{
    public class CheckoutDto
    {

        public Guid UserId { get; set; }

        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        public double TotalPrice { get; set; }
        public string? Color { get; set; }
        public string? Size { get; set; }

    }
}
/*[
  {
    "userId": "6abe270d-e90a-426f-9968-07f319649377",
    "productId": "1ea027bd-4034-4250-98ee-a4baaff01855",
    "quantity": 0,
    "date": "2024-05-07T10:00:20.846Z",
    "totalPrice": 54,
    "color": "red",
    "size": "m5"
  }
]*/