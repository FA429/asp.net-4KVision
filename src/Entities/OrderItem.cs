namespace sda_onsite_2_csharp_backend_teamwork.src.Entities
{
    public class OrderItem
    {

        public Guid Id { get; set; }
        public Guid InventoryId { get; set; }
        public Guid OrderId { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }

        public OrderItem()
        {

        }

    }
}