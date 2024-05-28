using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using Npgsql;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Enums;
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

      public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresEnum<Role>();
        }
    }
}






