

using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Repositories;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services
{
    public class OrderServices : IOrderService
    {
        private IOrderRepository _orderRepository;
        private IOrderItemRepository _orderItemRepository;
        private IConfiguration _config;
        private IMapper _mapper;



        public OrderServices(IOrderRepository orderRepository, IConfiguration config, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _config = config;
            _mapper = mapper;

        }

        public IEnumerable<Order> FindAll()
        {
            return _orderRepository.FindAll();

        }

        public Order? FindOne(Guid OrderId)
        {
            return _orderRepository.FindOne(OrderId); ;

        }

        public Order CreateOne(List<CheckoutDto> checkoutOrderItems)
        {
            //1.  loop thro the checkedoutOItems and create orderItem
            //2 add order item to orderItem table. OrderRepo.CreateOne(orderItems)
            var order = new Order();
            foreach (var item in checkoutOrderItems)
            {

                var orderItem = new OrderItem();
                orderItem.OrderId = order.Id;
                orderItem.InventoryId = item.InventoryId;
                orderItem.Quantity = item.Quantity;
                orderItem.TotalPrice = item.Amount;
                _orderItemRepository.CreateOne(orderItem);
            }
            return _orderRepository.CreateOne(order);
        }

        public Order CreateOne(List<OrderItem> OrderItem)
        {
            throw new NotImplementedException();
        }



        /*
                  1. create order
                  2. loop thro the checkedoutOItems and create OrderItem
                  3. done.
                  */



        public Order? DeleteOne(Guid OrderId)
        {
            var deleteOrder = _orderRepository.FindOne(OrderId);
            if (deleteOrder == null)
            {
                return null;
            }
            else
            {
                return _orderRepository.DeleteOne(OrderId);
            }


        }
    }
}
