using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Repositories;
using sdaonsite_2_csharp_backend_teamwork.src.Services;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controller
{

  public class CategoryService : ICategoryService

  {

    private ICategoryRepository _categoryRepository;
    private IMapper _mapper;

    public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
    {
      _categoryRepository = categoryRepository;
      _mapper = mapper;
    }

    public CategoryReadDto CreateOne(CategoryCreateDto category)
    {

      Category? mappedCategory = _mapper.Map<Category>(category);
      Category newCategory = _categoryRepository.CreateOne(mappedCategory);
      return _mapper.Map<CategoryReadDto>(newCategory);
    }

    public IEnumerable<Category> FindAll()
    {
      return _categoryRepository.FindAll();
    }

    public CategoryReadDto? FindOne(Guid categoryId)
    {
      var findItem = _categoryRepository.FindOne(categoryId);
      if (findItem == null)
      {
        return null;
      }
      return _mapper.Map<CategoryReadDto>(findItem);
    }
    public CategoryReadDto? DeleteOne(Guid categoryId)
    {
      var categoryFound = _categoryRepository.DeleteOne(categoryId);
      if (categoryFound != null)
      {

        return _mapper.Map<CategoryReadDto>(categoryFound);
      }

      throw new Exception("Item is not found");
    }

    public CategoryReadDto UpdateOne(Guid categoryId, CategoryUpdateDto categoryUpdate)
    {
      var category = _mapper.Map<Category>(categoryUpdate);
    

      var item = _categoryRepository.UpdateOne(category);
      if (item != null)
      {
        item.Type = category.Type;
        return _mapper.Map<CategoryReadDto>(item);
      }
      else
      {
        return null;
      }
    }


  }
}
