using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Databases
{
    public class DatabasesContext
    {
        public List<User> Users { get; set; }

        public DatabasesContext()
        {
            Users = [
            new User("1","user","Abbas","aa123","user23@gmail.com","0569113170"),
            new User("2","user","Fakhrdeen","ff123","user23@gmail.com","0501121033"),
        ];
        }
    }
}