using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IProductService
    {
        public IEnumerable<Product> FindAll();
        public Product? FindOne(Guid productId);
        public Product? CreateOne(ProductCreateDto product);
        public Product? DeleteOne(Guid productId);
        public Product? UpdateOne(Guid productId, Product product);
    }
}