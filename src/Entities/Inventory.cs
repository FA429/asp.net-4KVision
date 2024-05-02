namespace sda_onsite_2_csharp_backend_teamwork.src.Entities
{
    public class Inventory
    {

        public string Id { get; set; }
        public string Product_id { get; set; }
        public string Quantity { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public Inventory(string id, string product_id, string quantity, string color, string size)
        {
            Id = id;
            Product_id = product_id;
            Quantity = quantity;
            Color = color;
            Size = size;
        }
    }
}