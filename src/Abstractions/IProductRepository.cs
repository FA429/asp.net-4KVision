using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IProductRepository
    {
        public IEnumerable<Product> FindAll( string? searchKeyword);
        public Product? FindOne(Guid productId);
        public Product CreateOne(Product product);
        public bool? DeleteOne(Product product);
        public Product UpdateOne(Product product);
    }
}