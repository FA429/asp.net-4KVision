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
        public ActionResult<CheckoutDto> CreateOne([FromBody] List<CheckoutDto> checkedDtOItems)
        {
           var order = _orderService.CreateOne(checkedDtOItems);


            return CreatedAtAction(nameof(CreateOne), order);

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