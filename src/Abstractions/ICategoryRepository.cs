using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories
{
    public interface ICategoryRepository
    {
        public List<Category> FindAll();
        public Category CreateOne(Category category);
        public Category? FindOne(string categoryId);
        public Category? DeleteOne(string categoryId);

        public Category? UpdateOne(Category updateCategory);

    }
}