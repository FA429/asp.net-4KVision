using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Database
{

    public class DatabasesContext
    {
        public List<Category> categories;
        public DatabasesContext()
        {
            categories = [
            new Category("1", "phones"),
            new Category("2", "clothes"),
            new Category("3", "shoes")
            ];

        }
    }
}