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
        public ProductReadDto CreateOne(ProductCreateDto product)
        {
            var mappedOrderItem = _mapper.Map<Product>(product);
            _productRepository.CreateOne(mappedOrderItem);

            var newProduct = _mapper.Map<ProductReadDto>(product);


            return newProduct;
        }
        public bool? DeleteOne(Guid productId)
        {
            var deleteProduct = _productRepository.FindOne(productId);
            if (deleteProduct != null)
            {
                return _productRepository.DeleteOne(deleteProduct);
            }
            else
            {
                return false;
            }
        }
        public IEnumerable<ProductReadDto> FindAll(int limit , int offset)
        {
            IEnumerable<Product> products = _productRepository.FindAll(limit, offset);
            return products.Select(_mapper.Map<ProductReadDto>);
            
        }
        public ProductReadDto FindOne(Guid productId)
        {
            Product? products = _productRepository.FindOne(productId);
            return _mapper.Map<ProductReadDto>(products);
        }
        public ProductReadDto UpdateOne(Guid productId, ProductUpdateDto updatedProduct)
        {
            var product = _productRepository.FindOne(productId);
            //ToDo: implement if  statement for each property in product to check if it exists before updating
            if (product != null)
            {
                product.Name = updatedProduct.Name;
                product.CategoryId = updatedProduct.CategoryId;
                product.Price = updatedProduct.Price;
                _productRepository.UpdateOne(product);

                return _mapper.Map<ProductReadDto>(product);
            }
            return null;
        }
    }
}