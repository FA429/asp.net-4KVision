

using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sdaonsite_2_csharp_backend_teamwork.src.Services
{
    public interface ICategoryService
    {
        public List<Category> FindAll();
        public Category CreateOne(Category category);
        public Category FindOne(Category newcategory);
        public Category DeleteOne(Category Deletecategory);
        public Category UpdateOne(Category Updatecategory);


    }
}