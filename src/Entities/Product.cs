namespace sda_onsite_2_csharp_backend_teamwork.src.Entities
{
    public class Product
    {
        public Product(string id, string category_id, string name, int price)
        {
            Id = id;
            CategoryId = category_id;
            Name = name;
            Price = price;


        }
        public string Id { get; set; }
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}