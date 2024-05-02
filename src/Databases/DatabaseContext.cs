

using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Databases
{
    public class DatabaseContext : DbContext
    {
        public List<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public List<Product> Products { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        private IConfiguration _config;

        public DatabaseContext(IConfiguration config)
        {
            _config = config;
            Orders = [
                new Order ("1","11"),
                new Order ("2","22"),
            ];


            Products = [
            new Product("1","23","Iphone", "2000"),
            new Product("2","24","MacBook", "5000"),
        ];
            OrderItems = [
            new OrderItem("1","2","2","1","4900"),
            new OrderItem("2","3","1","1","7000"),
            new OrderItem("3","4","1","1","4900"),
            new OrderItem("4","1","2","1","7000"),
        ];

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(@$"Host={_config["Db:Host"]};Username={_config["Db:Username"]};Password={_config["Db:Password"]};Database={_config["Db:Database"]}")
                        .UseSnakeCaseNamingConvention();

    }
}