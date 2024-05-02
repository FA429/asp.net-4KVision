using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controllers
{
    public class InventoryController : CustomBaseController
    {
        private IInventoryService _inventoryService;

        public InventoryController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        [HttpGet]
        public List<Inventory> FindAll()
        {
            return _inventoryService.FindAll();
        }
        [HttpGet("{inventoryId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Inventory?> FindOne(string inventoryId)
        {
            return Ok(_inventoryService.FindOne(inventoryId));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Inventory?> CreateOne([FromBody] Inventory newInventory)
        {
            if (newInventory == null) return BadRequest();

            var createInventory = _inventoryService.CreateOne(newInventory);
            return CreatedAtAction(nameof(CreateOne), createInventory);
        }

        [HttpDelete("{inventoryId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]

        public ActionResult<Inventory?> DeleteOne(string inventoryId)
        {
            var deleteInventory = _inventoryService.FindOne(inventoryId);
            if(deleteInventory == null) return NoContent();

            return Ok(_inventoryService.DeleteOne(inventoryId));
        }

        [HttpPatch("{inventoryId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Inventory?> UpdateOne(string inventoryId, [FromBody] Inventory newInventory)
        {
            return Ok(_inventoryService.UpdateOne(inventoryId, newInventory));
        }
    }
}