using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<Order> FindAll()
        {
            return _orderService.FindAll();

        }
        [HttpGet("{OrderId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public ActionResult<Order?> FindOne(Guid orderId)
        {
            return _orderService.FindOne(orderId);

        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<CheckoutDto> CreateOne([FromBody] List<CheckoutDto> checkedoutOItems)
        {
            /*
            1. create order
            2. loop thro the checkedoutOItems and create OrderItem
            3. done.
            */
            foreach (var item in checkedoutOItems)
            {
                Console.WriteLine($"{item.InventoryId}");
            }

            if (checkedoutOItems != null)
            {

                // var createdOrder = _orderService.CreateOne(order);
                // return CreatedAtAction(nameof(CreateOne), createdOrder);
            }

            return BadRequest();

        }
        [HttpDelete("{orderId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]

        public ActionResult<Order?> DeleteOne(Guid orderId)
        {
            NoContent();
            return _orderService.DeleteOne(orderId);

        }



    }
}