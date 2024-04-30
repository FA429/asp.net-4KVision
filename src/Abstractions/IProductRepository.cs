
using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;


namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IProductRepository
    {

        public DbSet<Product> FindAll();
        public Product? FindOne(Guid productId);
        public Product CreateOne(Product product);
        public Product? DeleteOne(Guid productId);
        public Product UpdateOne(Product product);


    }
}