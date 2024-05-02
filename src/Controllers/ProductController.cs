using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;

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
        public IEnumerable<Product> FindAll()
        {

            return _productService.FindAll();
        }

        [HttpGet("{productId}")] //Action methods GET with Route attributes
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Product?> FindOne(Guid productId)
        {   
            return Ok(_productService.FindOne(productId));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)] // documentation error status code
        public ActionResult<Product> CreateOne([FromBody] ProductCreateDto product)
        {
            if (product is not null)
            {
                var createProduct = _productService.CreateOne(product);
                return CreatedAtAction(nameof(CreateOne), createProduct);
            }

            return BadRequest();
        }

        [HttpDelete("{productId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]// documentation error status code
        public ActionResult<Product?> DeleteOne(Guid productId)
        {
            NoContent();
            return _productService.DeleteOne(productId);
        }
        [HttpPatch("{productId}")]
        public Product? UpdateOne(Guid productId, [FromBody] Product product)
        {
            return _productService.UpdateOne(productId, product);
        }
    }
}
