using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Repositories;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controller
{
    public class CategoryRepository : ICategoryRepository
    {

        private List<Category> _categories;
        public CategoryRepository()
        {
            _categories = new DatabasesContext().categories;
        }

        public List<Category> FindAll()
        {
            return _categories;
        }

        public List<Category> CreateOne(Category category)
        {
            _categories.Add(category);
            return _categories;
        }
    }
}