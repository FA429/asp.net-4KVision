

using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
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
        private IInventoryRepository _inventoryRepository;
        private IProductRepository _productRepository;
        private IConfiguration _config;
        private IMapper _mapper;
        private IUserRepository _userRepository;



        public OrderServices(IOrderRepository orderRepository, IConfiguration config, IMapper mapper, IOrderItemRepository orderItemRepository, IInventoryRepository inventoryRepository, IProductRepository productRepository, IUserRepository userRepository)
        {
            _orderRepository = orderRepository;
            _config = config;
            _mapper = mapper;
            _orderItemRepository = orderItemRepository;
            _inventoryRepository = inventoryRepository;
            _productRepository = productRepository;
            _userRepository = userRepository;

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
            Console.WriteLine("================================");

            var order = new Order();
            
                var orderItem = new OrderItem();
                var inventory = new Inventory();
                var user = new User();
            order = await _orderRepository.CreateOne(order);

            foreach (var checkoutItem in checkoutOrderItems)
            {

                var findInventory = _inventoryRepository.FindAll().FirstOrDefault((inv) => inv.Size == checkoutItem.Size && inv.Color == checkoutItem.Color && inv.ProductId == checkoutItem.ProductId);
                orderItem.InventoryId = findInventory!.Id;
                
                Console.WriteLine($"================{checkoutItem.Size}{checkoutItem.Color}{checkoutItem.ProductId}=======================");
                orderItem.Quantity = checkoutItem.Quantity;
                if (inventory.Quantity >= checkoutItem.Quantity)
                {
                    orderItem.TotalPrice = checkoutItem.TotalPrice;
                    orderItem.OrderId = order.Id; // Set OrderId after order is created
                    order.UserId = user.Id;

                    await _orderItemRepository.CreateOne(orderItem);
                    Console.WriteLine($"================{orderItem}=======================");





                }
            }
            return order;






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
