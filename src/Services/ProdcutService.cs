using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private IConfiguration _config;
        private IMapper _mapper;
        public ProductService(IProductRepository productRepository, IConfiguration config , IMapper mapper)
        {
            _productRepository = productRepository;
            _config = config;
            _mapper =mapper;
        }
        public Product? CreateOne(ProductCreateDto product)
        {
            var mappedOrderItem = _mapper.Map<Product>(product);
            var newProduct = _productRepository.CreateOne(mappedOrderItem);
            return newProduct;
        }
        public Product? DeleteOne(Guid productId)
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
        public IEnumerable<Product> FindAll()
        {
            return _productRepository.FindAll();
        }
        public Product? FindOne(Guid productId)
        {
            return _productRepository.FindOne(productId);
        }
        public Product? UpdateOne(Guid productId, Product newProduct)
        {
            var product = _productRepository.FindOne(productId);
            if (product != null)
            {
                product.Name = newProduct.Name;
                return _productRepository.UpdateOne(product);
            }
            return null;
        }
    }
}