using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> FindAll();
        public Category CreateOne(Category category);
        public Category? FindOne(Guid categoryId);
        public Category? DeleteOne(Guid categoryId);

        public Category? UpdateOne(Category updateCategory);

    }
}