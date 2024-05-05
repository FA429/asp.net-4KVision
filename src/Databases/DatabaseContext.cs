using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
namespace sda_onsite_2_csharp_backend_teamwork.src.Databases
{
    public class DatabaseContext : DbContext // DbContext is built in calss to give me access to database (gateway to database)
    {
        public DbSet<Order> Orders { get; set; } // Dbset class is used to access data set using LINQ syntax and Dbset transfear it to SQL query commands.
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
            => optionsBuilder.UseNpgsql(@$"Host={_config["Db:Host"]};Username={_config["Db:Username"]};Password={_config["Db:Password"]};Database={_config["Db:Database"]}")
            .UseSnakeCaseNamingConvention();
    }
}






// => optionsBuilder.UseNpgsql(@$"Host={_config[":Host"]};Username={_config["Db:Username:"]};Password={_config["Db:Password"]};Database={_config["Db:Database"]}")