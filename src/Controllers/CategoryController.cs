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

        public List<Category> FindAll()

        {
            return _categoryService.FindAll();
        }

        [HttpPost]
        public Category? CreateOne([FromBody] Category category)
        {
            return _categoryService.CreateOne(category);
        }

        [HttpGet("{categoryId}")]
        public Category? FindOne(string categoryId)
        {
            return _categoryService.FindOne(categoryId);
        }


        [HttpDelete("{categoryId}")]
        public Category? DeleteOne([FromRoute] string categoryId)
        {
            return _categoryService.DeleteOne(categoryId);
        }

        [HttpPatch("{categoryId}")]
        public Category? UpdateOne(string categoryId, [FromBody] Category category)
        {
            return _categoryService.UpdateOne(categoryId, category);
        }
    }

}