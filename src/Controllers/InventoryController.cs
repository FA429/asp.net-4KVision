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
        public Inventory? FindOne(string inventoryId)
        {
            return _inventoryService.FindOne(inventoryId);
        }

        [HttpPost]
        public Inventory? CreateOne([FromBody] Inventory newInventory)
        {
            return _inventoryService.CreateOne(newInventory);
        }

        [HttpDelete("{inventoryId}")]
        public Inventory? DeleteOne(string inventoryId)
        {
            return _inventoryService.DeleteOne(inventoryId);
        }

        [HttpPatch("{inventoryId}")]
        public Inventory? UpdateOne(string inventoryId, [FromBody]Inventory newInventory)
        {
            return null;
        }
    }
}