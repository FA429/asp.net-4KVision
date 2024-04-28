using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controller
{

    public class CategoryController : CustomBaseController
    {


        private List<Category> _categories;
        public CategoryController()
        {
            _categories = new DatabasesContext().categories;
        }
    }



}
