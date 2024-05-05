
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sdaonsite_2_csharp_backend_teamwork.src.Services
{
    public interface ICategoryService
    {
        public IEnumerable<Category> FindAll();
        public CategoryReadDto CreateOne(CategoryCreateDto category);
        public CategoryReadDto? FindOne(Guid categoryId);
        public CategoryReadDto? DeleteOne(Guid categoryId);

        public CategoryReadDto? UpdateOne(Guid categoryId, CategoryUpdateDto newValue);



    }
}