using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Databases
{
    public class DatabasesContext
    {
        public List<User> Users { get; set; }
        public List<OrderItem> Order_Item { get; set; }


        public DatabasesContext()
        {
            Users = [
            new User("1","user","Abbas","aa123","user23@gmail.com","0569113170"),
            new User("2","user","Fakhrdeen","ff123","user23@gmail.com","0501121033"),
        ];
            Order_Item = [
            new OrderItem("1","2","3","1","4900"),
            new OrderItem("2","3","4","1","7000"),
            new OrderItem("3","4","1","1","4900"),
            new OrderItem("4","1","2","1","7000"),
        ];
        }
    }
}