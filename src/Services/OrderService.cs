

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services
{
    public class OrderServices : IOrderService
    {
        private IOrderRepository _orderRepository;
                private IConfiguration _config;
                


        public OrderServices(IOrderRepository orderRepository, IConfiguration config)
        {
            _orderRepository = orderRepository;
                        _config = config;

        }

        public IEnumerable<Order> FindAll()
        {
            return _orderRepository.FindAll();

        }

        public Order? FindOne(Guid OrderId)
        {
            return _orderRepository.FindOne(OrderId); ;

        }

        public CheckoutDto CreateOne([FromBody] List<CheckoutDto> checkedoutO)
        {
            //ublic ActionResult<Order> CreateOne([FromBody] List<CheckoutDto> checkedoutOItems
foreach (var item in checkedoutO)
            
            {
           return _orderRepository.CreateOne(item.InventoryId);
            }


//   foreach (var item in checkedoutO)
//             {
//                 Console.WriteLine($"{item.InventoryId}");
            
//             return _orderRepository.CreateOne(item);
//             }
              /*
            1. create order
            2. loop thro the checkedoutOItems and create OrderItem
            3. done.
            */

        }

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