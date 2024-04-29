using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IOrderItemService
    {
        public List<OrderItem> FindAll();
        public OrderItem? FindOne(string orderItemId);
        public OrderItem CreateOne( OrderItem newOrderItem);
        public OrderItem? DeleteOne(string orderItemId);
        public OrderItem? UpdateOne(string orderItemId, OrderItem newValue);
    }
}
