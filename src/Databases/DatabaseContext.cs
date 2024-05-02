using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
namespace sda_onsite_2_csharp_backend_teamwork.src.Databases
{
    public class DatabaseContext : DbContext
    {
     public DbSet<Product> Products { get; set; }
     private IConfiguration _config;

    public DatabaseContext(IConfiguration config)
    {
        _config = config;

    }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        => optionsBuilder.UseNpgsql (@"Host= nameof server;Username=admin;Password=mypass;DatabaseName=jkdsakl");
    }
}