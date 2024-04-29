using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Repositories;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controller
{
    public class CategoryRepository : ICategoryRepository
    {

        private List<Category> _categories;
        public CategoryRepository()
        {
            _categories = new DatabaseContext().categories;
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
        public Category? FindOne(string categoryId)
        {
            var foundCategory = _categories.FirstOrDefault(category => category.Id == categoryId);
            return foundCategory;
        }
        public Category? DeleteOne(string categoryId)
        {
            var categoryFound = FindOne(categoryId);
            _categories.Remove(categoryFound!);
            return categoryFound;
        }

        public Category? UpdateOne(Category updateCategory)
        {
            var categories = _categories.Select(item =>
            {
                if (item.Id == updateCategory.Id)
                {
                    return updateCategory;
                }
                return item;
            });
            _categories = categories.ToList();
            return updateCategory;
        }
    }
}