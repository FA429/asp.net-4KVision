

using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Databases
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public List<User> Users { get; set; }
        public List<Product> Products { get; set; }
        public List<OrderItem> Order_Item { get; set; }
        public List<Category> categories;


        private IConfiguration _configuration;

        public DatabaseContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DatabaseContext()
        {


            Users = [
            new User("1","user","Faisal","aa123","user23@gmail.com","0569113170"),
            new User("2","user","Fakhrdeen","ff123","user23@gmail.com","0501121033"),
        ];
            Products = [
            new Product("1","23","Iphone", "2000"),
            new Product("2","24","MacBook", "5000"),
        ];
            Order_Item = [
            new OrderItem("1","2","2","1","4900"),
            new OrderItem("2","3","1","1","7000"),
            new OrderItem("3","4","1","1","4900"),
            new OrderItem("4","1","2","1","7000"),
        ];
            categories = [
            new Category("1", "phones"),
            new Category("2", "clothes"),
            new Category("3", "shoes")
                ];
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(@$"Host=localhost;Username=postgres;Password=123123;Database=Stor")
        .UseSnakeCaseNamingConvention();

    }
}