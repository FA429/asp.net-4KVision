using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork.src.Entities
{
    public class Category
    {
        
        public string id { get; set; }
       public string type { get; set; }
        public Category(string id, string type)
        {
            this.id = id;
            this.type = type;
        }
    }
}