using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IOrderItemRepository
    {
        public List<OrderItem> FindAll();
        public OrderItem? FindOne(string orderId);
        public OrderItem CreateOne(OrderItem NewOrderItem);
    }
}