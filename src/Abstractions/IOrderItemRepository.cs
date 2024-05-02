using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IOrderItemRepository
    {
        public IEnumerable<OrderItem> FindAll();
        public OrderItem? FindOne(Guid orderId);
        public OrderItem CreateOne(OrderItem NewOrderItem);
        public OrderItem? DeleteOne(Guid orderItemId);
        public OrderItem? UpdateOne(OrderItem updatedItem);


    }
}