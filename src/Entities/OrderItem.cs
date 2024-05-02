namespace sda_onsite_2_csharp_backend_teamwork.src.Entities
{
    public class OrderItem
    {
        public OrderItem(string id, string inventory_id, string order_id, string quantity, string total_price)
        {
            Id = id;
            Inventory_id = inventory_id;
            Order_id = order_id;
            Quantity = quantity;
            Total_price = total_price;
        }

        public string Id { get; set; }
        public string Inventory_id { get; set; }
        public string Order_id { get; set; }
        public string Quantity { get; set; }
        public string Total_price { get; set; }

    }
}