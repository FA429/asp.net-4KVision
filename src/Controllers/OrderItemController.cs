using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controllers
{
    public class OrderItemController : CustomBaseController
    {
        private IOrderItemService _orderItemService;

        public OrderItemController(IOrderItemService orderItemService)
        {
            _orderItemService = orderItemService;
        }

        [HttpGet]
        public List<OrderItem> FindAll()
        {
            return _orderItemService.FindAll();
        }

        [HttpGet("{orderItemId}")]
        public OrderItem? FindOne(string orderItemId)
        {
            return _orderItemService.FindOne(orderItemId);
        }

        [HttpPost]
        public OrderItem? CreateOne([FromBody] OrderItem NewOrderItem)
        {
            return _orderItemService.CreateOne(NewOrderItem);
        }

        [HttpDelete("{orderItemId}")]
        public OrderItem? DeleteOne(string orderItemId)
        {
            return _orderItemService.DeleteOne(orderItemId);
        }

        [HttpPatch("{orderItemId}")]
        public OrderItem? UpdateOne(string orderItemId, [FromBody] OrderItem item)
        {
            return _orderItemService.UpdateOne(orderItemId, item);
        }
    }
}