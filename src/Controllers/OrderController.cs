using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Controllers;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Order>> FindAll()
        {
            return Ok(_orderService.FindAll());

        }
        [HttpGet("{OrderId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult<Order?> FindOne(Guid orderId)
        {
            var orders = _orderService.FindAll();
            var order = orders.FirstOrDefault(o => o.Id == orderId);
            if (order == null) return NoContent();
            return Ok(_orderService.FindOne(orderId));
        }

        [Authorize(Roles = "Admin,Customer")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Order> CreateOne([FromBody] List<CheckoutDto> checkoutOrder)
        {
            string? userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (checkoutOrder != null && userId != null)
            {
                var createdOrder = _orderService.CreateOne(checkoutOrder, userId);
                return CreatedAtAction(nameof(CreateOne), createdOrder);
            }
            return BadRequest();
        }
        [HttpDelete("{orderId}")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Order?> DeleteOne(Guid orderId)
        {
            var findOrder = _orderService.FindOne(orderId);
            if (findOrder == null) return NotFound();
            return Accepted(_orderService.DeleteOne(orderId));
        }
    }
}