using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
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
        public List<Category> CreateOne([FromBody] Category category)
        {
            return _categoryService.CreateOne(category);
        }
    }

}
