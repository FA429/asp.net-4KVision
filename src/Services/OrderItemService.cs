using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services
{
    public class OrderItemService : IOrderItemService
    {
        private IOrderItemRepository _orderItemRepository;
        private IMapper _mapper;

        public OrderItemService(IOrderItemRepository orderItemRepository, IMapper mapper)
        {
            _orderItemRepository = orderItemRepository;
            _mapper = mapper;
        }

        public OrderItem? CreateOne(OrderItemCreateDto newOrderItem)
        {
            var mappedOrderItem = _mapper.Map<OrderItem>(newOrderItem);
            var newItem = _orderItemRepository.CreateOne(mappedOrderItem);
            return newItem;
        }

        public OrderItem? DeleteOne(Guid orderItemId)
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

             var orderItems = _orderItemRepository.FindAll();
             return orderItems.ToList();
        }

        public OrderItem? FindOne(Guid orderItemId)
        {
            return _orderItemRepository.FindOne(orderItemId);
        }

        public OrderItem? UpdateOne(Guid orderItemId, OrderItem newValue)
        {
            var item = _orderItemRepository.FindOne(orderItemId);
            if (item == null)
            {
                return null;
            }
            else
            {
                item.Quantity = newValue.Quantity;
                item.Total_price = newValue.Total_price;
                return _orderItemRepository.UpdateOne(item);
            }
        }
    }
}