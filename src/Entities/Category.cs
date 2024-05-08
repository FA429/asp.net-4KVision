
namespace sda_onsite_2_csharp_backend_teamwork.src.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public List<Product>? Product { get; set; } // Navigation Property
    }
}