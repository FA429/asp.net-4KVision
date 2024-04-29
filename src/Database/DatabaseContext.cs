using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Databases
{
    public class DatabaseContext
    {
        public List<User> Users { get; set; }
        public List<Product> Products { get; set; }
        public List<Order> Order { get; set; }

        public DatabaseContext()
        {
            Users = [
            new User("1","user","Abbas","aa123","user23@gmail.com","0569113170"),
            new User("2","user","Fakhrdeen","ff123","user23@gmail.com","0501121033"),
        ];
            Products = [
            new Product("1","23","Iphone", "2000"),
            new Product("2","24","MacBook", "5000"),
        ];
            Order = [
                    new Order ("1","11"),
                new Order ("2","22"),
            ];

        }


    }
}