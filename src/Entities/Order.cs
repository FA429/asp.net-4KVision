

namespace sda_onsite_2_csharp_backend_teamwork.src.Entities
{
    public class Order
    {
    

        public Guid Id { get; set; }
        public string UserId { get; set; }
        public DateTime Date { get; set; }= new DateTime();

    }
}