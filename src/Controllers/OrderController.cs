using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Controllers;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src
{
    public class OrderController : CustomBaseController
    {
        private IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]

        public List<Order> FindAll()
        {
            return _orderService.FindAll();

        }
        [HttpGet("{OrderId}")]
        public Order? FindOne(string OrderId)
        {
            return _orderService.FindOne(OrderId);

        }

        [HttpPost]
        public Order CreateOne([FromBody] Order order)
        {
            return _orderService.CreateOne(order);

        }

        [HttpDelete("{OrderId}")]
        public Order? DeleteOne(string OrderId)
        {
            return _orderService.DeleteOne(OrderId);

        }



    }
}