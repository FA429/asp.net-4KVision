using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories

{
    public class ProductRepository : IProductRepository
    {
        private DbSet<Product> _products;
        private DatabaseContext _databaseContext;

        public ProductRepository(DatabaseContext databaseContext)
        {
            _products = databaseContext.Products;
            _databaseContext = databaseContext;
        }
        public Product CreateOne(Product product)
        {
            _products.Add(product);
            _databaseContext.SaveChanges();
            return product;
        }
        public bool? DeleteOne(Product product)
        {
            _products.Remove(product!);
            _databaseContext.SaveChanges();
            return true;
        }
        public IEnumerable<Product> FindAll()
        {
            return _products;
        }
        public Product? FindOne(Guid productId)
        {
            var findProduct = _products.Find(productId);
            return findProduct;
        }
        public Product UpdateOne(Product UpdateProduct)
        {
            _databaseContext.Products.Update(UpdateProduct);
            _databaseContext.SaveChanges();

            return UpdateProduct;
        }
    }
}

        