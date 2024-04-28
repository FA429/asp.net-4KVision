using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IOrderItemService
    {
        public List<OrderItem> FindAll();
        public OrderItem? FindOne(string orderId);
    }
}
