namespace sda_onsite_2_csharp_backend_teamwork.src.Entities
{
    public class Product
    {
        public Product(string id, string categoryId, string name, string price)
        {
            Id = id;
            CategoryId = categoryId;
            Name = name;
            Price = price;
        }
        public string Id { get; set; }
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
    }
}