using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories
{
    public interface ICategoryRepository
    {
        public List<Category> FindAll();
        public List<Category> CreateOne(Category category);

    }
}