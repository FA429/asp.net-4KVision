using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controllers
{

    public class ProductController : CustomBaseController
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {

            _productService = productService;


        }
        [HttpGet] //Action methods GET
        public DbSet<Product> FindAll()
        {

            return _productService.FindAll();
        }

        [HttpGet("{productId}")] //Action methods GET with Route attributes
        public Product? FindOne(Guid productId)
        {

            return _productService.FindOne(productId);
        }

        [HttpPost]
        public Product CreateOne([FromBody] Product product)
        {
            Console.WriteLine($"controller {product.Name}");

            return product;
        }

        [HttpDelete("{productId}")]
        public Product? DeleteOne(Guid productId)
        {
            return _productService.DeleteOne(productId);
        }

        [HttpPatch("{productId}")]
        public Product? UpdateOne(Guid productId, [FromBody] Product product)
        {

            return _productService.UpdateOne(productId, product);
        }
    }
}