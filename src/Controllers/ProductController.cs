using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using System.Reflection.Metadata.Ecma335;

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
        public List<Product> FindAll()
        {

            return _productService.FindAll();
        }

        [HttpGet("{ProductId}")] //Action methods GET with Route attributes
        public Product? FindOne(string productId)
        {

            return _productService.FindOne(productId);
        }

        [HttpPost]
        public Product CreateOne([FromBody] Product product)
        {

            return _productService.CreateOne(product);
        }
        [HttpDelete("{ProductId}")]
        public List<Product> DeleteOne(string ProductId)
        {
            return _productService.DeleteOne(ProductId);
        }

        [HttpPatch("{ProductId}")]
        public Product? UpdateOne(string ProductId, [FromBody] Product product)
        {

            return _productService.UpdateOne(ProductId, product);
        }
    }
}