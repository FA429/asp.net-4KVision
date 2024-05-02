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

    public List<Category> FindAll()
    {
      return _categoryRepository.FindAll();
    }

    public Category? FindOne(string categoryId)
    {
      var findItem = _categoryRepository.FindAll().Find(item => item.Id == categoryId);
      if (findItem == null)
      {
        return null;
      }
      return _categoryRepository.FindOne(categoryId);
    }
    public Category? DeleteOne(string categoryId)
    {
      var categoryFound = _categoryRepository.FindOne(categoryId);
      if (categoryFound != null)
      {
        return _categoryRepository.DeleteOne(categoryId);
      }

      return null;
    }

        public Category? UpdateOne(string categoryId, Category newValue)
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