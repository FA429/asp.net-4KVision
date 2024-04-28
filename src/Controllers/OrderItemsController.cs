using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controllers
{
    public class OrderItemsController : CustomBaseControllerController
    {
        private IOrderItemService _orderItemService;

        public OrderItemsController(IOrderItemService orderItemService)
        {
            _orderItemService = orderItemService;
        }

        [HttpGet]
        public List<OrderItem> FindAll()
        {
            return _orderItemService.FindAll();
        }

        [HttpGet("{orderId}")]
        public OrderItem? FindOne(string orderId)
        {
            return _orderItemService.FindOne(orderId);
        }

        [HttpPost]
        public OrderItem CreateOne([FromBody] OrderItem NewOrderItem)
        {
            return _orderItemService.CreateOne(NewOrderItem);
        }

    }
}