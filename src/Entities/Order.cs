

namespace sda_onsite_2_csharp_backend_teamwork.src.Entities
{
    public class Order
    {
        public Order( string id, string user_id)
        {
            Id = id;
            User_id = user_id;
        }

        public string Id { get; set; }
        public string User_id { get; set; }
        public DateTime Date { get; set; }= new DateTime();

    }
}