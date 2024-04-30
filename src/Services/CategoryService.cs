using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Repositories;
using sdaonsite_2_csharp_backend_teamwork.src.Services;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controller
{

  public class CategoryService : ICategoryService

  {

    private ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
      _categoryRepository = categoryRepository;
    }

    public Category CreateOne(Category category)
    {
      return _categoryRepository.CreateOne(category);
    }

    public DbSet<Category> FindAll()
    {
      return _categoryRepository.FindAll();
    }

    public Category? FindOne(Guid categoryId)
    {

      return _categoryRepository.FindOne(categoryId);
    }
    public Category? DeleteOne(Guid categoryId)
    {
      var categoryFound = _categoryRepository.FindOne(categoryId);
      if (categoryFound != null)
      {
        return _categoryRepository.DeleteOne(categoryId);
      }

      return null;
    }

        public Category? UpdateOne(Guid categoryId, Category newValue)
        {

          var item = _categoryRepository.FindOne(categoryId);
          if(item != null){
            item.Type = newValue.Type;
            return _categoryRepository.UpdateOne(item);
          }
          else{
            return null;
          }
        }
    }
}