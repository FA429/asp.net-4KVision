

using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Databases
{
    public class DatabaseContext
    {
        public List<Order> Order { get; set; }
        public List<User> Users { get; set; }

        public DatabaseContext()
        {
            Order = [
                new Order ("1","11"),
                new Order ("2","22"),
            ];

            Users = [
            new User("1","user","Faisal","aa123","user23@gmail.com","0569113170"),
            new User("2","user","Fakhrdeen","ff123","user23@gmail.com","0501121033"),
        ];
        }
        
    }
}