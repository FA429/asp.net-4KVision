using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services
{
    public class OrderItemService : IOrderItemService
    {
        private IOrderItemRepository _orderItemRepository;

        public OrderItemService(IOrderItemRepository orderItemRepository)
        {
            _orderItemRepository = orderItemRepository;
        }

        public OrderItem CreateOne(OrderItem NewOrderItem)
        {
            return _orderItemRepository.CreateOne(NewOrderItem);
        }

        public List<OrderItem> FindAll()
        {
            return _orderItemRepository.FindAll();
        }

        public OrderItem? FindOne(string orderId)
        {
            return _orderItemRepository.FindOne(orderId);
        }
    }
}