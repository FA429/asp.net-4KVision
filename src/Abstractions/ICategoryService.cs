
using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sdaonsite_2_csharp_backend_teamwork.src.Services
{
    public interface ICategoryService
    {
        public DbSet<Category> FindAll();
        public Category CreateOne(Category category);
        public Category? FindOne(Guid categoryId);
        public Category? DeleteOne(Guid categoryId);

        public Category? UpdateOne(Guid categoryId, Category newValue);



    }
}