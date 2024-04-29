using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork.src.Entities
{
    public class Category
    {
        
        public string Id { get; set; }
        public string Type { get; set; }
        public Category(string id, string type)
        {
            Id = id;
            Type = type;
        }
    }
}