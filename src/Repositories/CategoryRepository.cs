using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private DbSet<Category> _categories;
        private DatabaseContext _databaseContext;

        public CategoryRepository(DatabaseContext databaseContext)
        {
            _categories = databaseContext.Categories;
            _databaseContext = databaseContext;
        }

        public Category CreateOne(Category category)
        {
            _categories.Add(category);
            _databaseContext.SaveChanges();
            return category;
        }

        public Category? DeleteOne(Guid categoryId)
        {
            var deleteCategory = FindOne(categoryId);
            if (deleteCategory != null)
            {
                _categories.Remove(deleteCategory);
                _databaseContext.SaveChanges();
            }
            return deleteCategory;
        }

        public IEnumerable<Category> FindAll()
        {
            return _categories;
        }

        public Category? FindOne(Guid categoryId)
        {
            var findCategory = _categories.Find(categoryId);
            return findCategory;
        }

        public Category? UpdateOne(Category updatedCategory)
        {
            // var category = _categories.FirstOrDefault(item => item.Id == updatedCategory.Id);
            // if (category != null)
            // {
            //     category.Type = updatedCategory.Type;
            //     _databaseContext.SaveChanges();
            // }
            return updatedCategory;
        }
    }
}
