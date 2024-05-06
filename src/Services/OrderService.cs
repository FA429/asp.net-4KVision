

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



        public OrderServices(IOrderRepository orderRepository, IConfiguration config, IMapper mapper, IOrderItemRepository orderItemRepository)
        {
            _orderRepository = orderRepository;
            _config = config;
            _mapper = mapper;
            _orderItemRepository = orderItemRepository;

        }

        public IEnumerable<Order> FindAll()
        {
            return _orderRepository.FindAll();

        }

        public Order? FindOne(Guid OrderId)
        {
            return _orderRepository.FindOne(OrderId); ;

        }

        public async Task<Order> CreateOne(List<CheckoutDto> checkoutOrderItems)
        {
            try
            {
                var order = new Order();
                // order.UserId = new Guid("f0098fdc-10fb-4a4b-8caa-84713c621b34");

                // Create the order and wait for it to be created
                // order = await _orderRepository.CreateOne(order);
                Console.WriteLine($"======{_orderItemRepository}");

                foreach (var item in checkoutOrderItems)
                {
                    var orderItem = new OrderItem();
                    orderItem.InventoryId = item.InventoryId;
                    orderItem.Quantity = item.Quantity;
                    orderItem.TotalPrice = item.TotalPrice;
                    orderItem.OrderId = new Guid("04c620a9-079c-4b9d-86ca-03d20baa6370"); // Set OrderId after order is created
                    await _orderItemRepository.CreateOne(orderItem);
                }

                return order;
            }
            catch (Exception ex)
            {
                // Log exception details
                Console.WriteLine($"Exception occurred: {ex}");
                throw; // Rethrow the exception
            }

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
