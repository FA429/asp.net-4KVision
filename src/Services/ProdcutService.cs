using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Product CreateOne(Product product)
        {
            return _productRepository.CreateOne(product);
        }
        public Product? DeleteOne(string productId)
        {
            var deleteProduct = _productRepository.FindOne(productId);
            if (deleteProduct != null)
            {
                return _productRepository.DeleteOne(productId);
            }
            else
            {
                return null;
            }
        }
        public List<Product> FindAll()
        {
            return _productRepository.FindAll();
        }
        public Product? FindOne(string productId)
        {
            return _productRepository.FindOne(productId);
        }
        public Product? UpdateOne(string productId, Product newProduct)
        {
            var product = _productRepository.FindOne(productId);
            if (product != null)
            {
                product.Name = newProduct.Name;
                return _productRepository.UpdateOne(product);
            }
            return null;
        }

        public List<Product> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}