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
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<ProductReadDto>> FindAll([FromQuery(Name = "limit")] int limit, [FromQuery(Name = "offset")] int offset)
        {

            return Ok(_productService.FindAll(limit, offset));
        }

        [HttpGet("{productId}")] //Action methods GET with Route attributes
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ProductReadDto?> FindOne(Guid productId)
        {
            ProductReadDto? foundProduct = _productService.FindOne(productId);
            if (foundProduct is null) return NoContent();
            return Ok(foundProduct);

        }
        [HttpGet("search")] //Action method for searching products by keyword
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<ProductReadDto>> Search(string keyword)
        {
            List<ProductReadDto> foundProducts = _productService.Search(keyword);
            if (foundProducts.Count == 0)
                return NotFound();

            return Ok(foundProducts);
        }




        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)] // documentation error status code
        public ActionResult<ProductReadDto> CreateOne([FromBody] ProductCreateDto product)
        {
            if (product is not null)
            {
                var createProduct = _productService.CreateOne(product);
                return CreatedAtAction(nameof(CreateOne), createProduct);
            }

            return BadRequest();
        }

        [HttpDelete("{productId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]// documentation error status code
        public ActionResult<Product?> DeleteOne(Guid productId)
        {
            var deletedProduct = _productService.DeleteOne(productId);
            if (deletedProduct == null)
            {
                return NotFound();
            }
            return NoContent();
        }


        [HttpPatch("{productId}")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Product> UpdateOne(Guid productId, [FromBody] ProductUpdateDto updateProduct)
        {
            var foundProduct = FindOne(productId);

            if (foundProduct != null)
            {
                ProductReadDto product = _productService.UpdateOne(productId, updateProduct);

                return Accepted(product);
            }
            return NotFound();
        }
    }
}
