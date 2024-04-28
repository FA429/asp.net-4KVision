

using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Databases
{
    public class DatabaseContext
    {
public List<Order> order { get; set; }
        public DatabaseContext()
        {
            order =[
                new Order ("1","11"),
                new Order ("2","22"),
            ];
        }
    }
}