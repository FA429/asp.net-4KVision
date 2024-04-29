
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sdaonsite_2_csharp_backend_teamwork.src.Services
{
    public interface ICategoryService
    {
              public List<Category> FindAll();
        public Category CreateOne(Category category);
        public Category? FindOne(string categoryId);
        public Category? DeleteOne(string categoryId);

        public Category? UpdateOne(string categoryId, Category newValue );



    }
}