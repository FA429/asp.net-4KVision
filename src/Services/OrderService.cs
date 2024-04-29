

using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services
{
    public class OrderServices : IOrderService
    {
private IOrderRepository _orderRepository;

        public OrderServices(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public List<Order> FindAll()
        {
            return _orderRepository.FindAll();

        }

public Order? FindOne(string OrderId)
        {
            return _orderRepository.FindOne(OrderId);;

        }

         public List<Order> CreateOne([FromBody] Order order)
        {
            
            return _orderRepository.CreateOne(order);;

        }

        public List<Order> DeleteOne(string OrderId)
        {
            throw new NotImplementedException();
        }
    }
}