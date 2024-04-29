using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Controllers;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
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
        public List<Order> CreateOne([FromBody] Order order)
        {
            return _orderService.CreateOne(order);

        }

        [HttpDelete("{OrderId}")]
        public List<Order> DeleteOne(string OrderId){
            return _orderService.DeleteOne(OrderId);

        }



    }
}