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

        public OrderItem? DeleteOne(string orderItemId)
        {
            var deleteItem = _orderItemRepository.FindOne(orderItemId);
            if (deleteItem != null)
            {
             return _orderItemRepository.DeleteOne(orderItemId);
            }
            else
            {
                return null;
            }
        }

        public List<OrderItem> FindAll()
        {
            return _orderItemRepository.FindAll();
        }

        public OrderItem? FindOne(string orderItemId)
        {
            return _orderItemRepository.FindOne(orderItemId);
        }

        public OrderItem? UpdateOne(string orderItemId, OrderItem newValue)
        {
            var item = _orderItemRepository.FindOne(orderItemId);
            if (item!= null)
            {
                item.Quantity = newValue.Quantity;
                item.Total_price = newValue.Total_price;
                return _orderItemRepository.UpdateOne(item);
            }
            else
            {
                return null;
            }
        }
    }
}