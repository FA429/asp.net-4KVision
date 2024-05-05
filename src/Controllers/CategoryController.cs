using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Controllers;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sdaonsite_2_csharp_backend_teamwork.src.Services;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controller
{
    public class CategoryController : CustomBaseController
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Category>> FindAll()
        {
            return Ok(_categoryService.FindAll());
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Category> CreateOne([FromBody] CategoryCreateDto category)
        {
            var createdCategory = _categoryService.CreateOne(category);
            if (createdCategory != null)
            {
                return CreatedAtAction(nameof(CreateOne), createdCategory);
            }
            return BadRequest();
        }

        [HttpGet("{categoryId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public ActionResult<Category> FindOne(Guid categoryId)
        {
            var category = _categoryService.FindOne(categoryId);
            if (category != null)
            {
                return Ok(category);
            }
            return NotFound();
        }

        [HttpDelete("{categoryId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]

        public ActionResult<Category> DeleteOne([FromRoute] Guid categoryId)
        {
            var deletedCategory = _categoryService.DeleteOne(categoryId);
            if (deletedCategory != null)
            {
                return Ok(deletedCategory);
            }
            return NotFound();
        }

        [HttpPatch("{categoryId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public ActionResult<Category> UpdateOne(Guid categoryId, [FromBody] CategoryUpdateDto category)
        {
            var updatedCategory = _categoryService.UpdateOne(categoryId, category);
            if (updatedCategory != null)
            {
                return Ok(updatedCategory);
            }
            return NotFound();
        }
    }

}
