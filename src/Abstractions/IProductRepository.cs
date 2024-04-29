using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IProductRepository
    {
        public List<Product> FindAll();
        public Product? FindOne(string productId);
        public Product CreateOne(Product product);
        public Product? DeleteOne(string productId);
        public Product UpdateOne(Product product);

    }
}