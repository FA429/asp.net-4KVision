using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services
{
    public class ProdcutService : IProductService
    {

        private IProductRepository _prodcutRepository;

        public ProdcutService(IProductRepository productRepository)
        {

            _prodcutRepository = productRepository;

        }
        public Product CreateOne(Product product)
        {
            Console.WriteLine($"service {product.Name}");

            return _prodcutRepository.CreateOne(product);
        }

        public Product? DeleteOne(string productId)
        {

            var deleteProduct = _prodcutRepository.FindOne(productId);
            if (deleteProduct != null)
            {
                return _prodcutRepository.DeleteOne(productId);
            }
            else
            {
                return null;
            }

        }


        public List<Product> FindAll()
        {
            return _prodcutRepository.FindAll();
        }

        public Product? FindOne(string productId)
        {
            return _prodcutRepository.FindOne(productId);
        }

        public Product? UpdateOne(string productId, Product newproduct)
        {
            var product = _prodcutRepository.FindOne(productId);
            if (product != null)
            {
                product.Name = newproduct.Name;
                return _prodcutRepository.UpdateOne(product);
            }

            return null;
        }
    }
}