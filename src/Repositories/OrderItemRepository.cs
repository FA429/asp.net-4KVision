using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private List<OrderItem> _orderItems;

        public OrderItemRepository()
        {
            _orderItems = new DatabaseContext().Order_Item;
        }

        public OrderItem CreateOne(OrderItem NewOrderItem)
        {
            _orderItems.Add(NewOrderItem);
            return NewOrderItem;
        }

        public OrderItem? DeleteOne(string orderItemId)
        {
            var deleteItem = FindOne(orderItemId);
                _orderItems.Remove(deleteItem!);
                return deleteItem;
        }
        public List<OrderItem> FindAll()
        {
            return _orderItems;
        }

        public OrderItem? FindOne(string orderId)
        {
            var FindOrderItem = _orderItems.Find((item) => item.Id == orderId);
            return FindOrderItem;
        }
    }
}