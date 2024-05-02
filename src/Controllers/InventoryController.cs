using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
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
        public IEnumerable<Inventory> FindAll()
        {
            return _inventoryService.FindAll();
        }
        [HttpGet("{inventoryId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult<Inventory?> FindOne(Guid inventoryId)
        {
            List<Inventory> inventories = _inventoryService.FindAll();
            Inventory? isFound = inventories.Find(inventory => inventory.Id == inventoryId);
            if(isFound == null) return NoContent();
            return Ok(_inventoryService.FindOne(inventoryId));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Inventory?> CreateOne([FromBody] InventoryCreateDto newInventory)
        {
            if (newInventory == null) return BadRequest();

            var createInventory = _inventoryService.CreateOne(newInventory);
            return CreatedAtAction(nameof(CreateOne), createInventory);
        }

        [HttpDelete("{inventoryId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public ActionResult<Inventory?> DeleteOne(Guid inventoryId)
        {
            var deleteInventory = _inventoryService.FindOne(inventoryId);
            if(deleteInventory == null) return NoContent();

            return Ok(_inventoryService.DeleteOne(inventoryId));
        }

        [HttpPatch("{inventoryId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Inventory?> UpdateOne(Guid inventoryId, [FromBody] Inventory updateInventory)
        {
            return Ok(_inventoryService.UpdateOne(inventoryId, updateInventory));
        }
    }
}