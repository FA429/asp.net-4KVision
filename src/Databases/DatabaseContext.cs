using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
namespace sda_onsite_2_csharp_backend_teamwork.src.Databases
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        private IConfiguration _config;

        public DatabaseContext(IConfiguration config)
        {
            _config = config;

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=e-commerce_db;Password=12345678Aa;Username=postgres")
            .UseSnakeCaseNamingConvention();
    }
}






// => optionsBuilder.UseNpgsql(@$"Host={_config[":Host"]};Username={_config["Db:Username:"]};Password={_config["Db:Password"]};Database={_config["Db:Database"]}")