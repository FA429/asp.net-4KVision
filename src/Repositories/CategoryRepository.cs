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

        public Category CreateOne(Category category)
        {
            _categories.Add(category);
            return category;
        }
         public Category FindOne(Category newcategory)
        {
            _categories.FirstOrDefault(category => category.Id == newcategory.Id);
            return  newcategory;
        }
           public Category DeleteOne(Category Deletecategory)
        {
            _categories.FirstOrDefault(category => category.Id == Deletecategory.Id);
            return  Deletecategory;
        }

            public Category UpdateOne(Category Updatecategory)
        {
            _categories.FirstOrDefault(category => category.Id == Updatecategory.Id);
            return  Updatecategory;
        }
    }
}