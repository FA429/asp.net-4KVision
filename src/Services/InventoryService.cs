using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services
{
    public class InventoryService : IInventoryService
    {
        private IInventoryRepository _inventoryRepository;

        public InventoryService(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        public Inventory? CreateOne(Inventory newInventory)
        {
            return _inventoryRepository.CreateOne(newInventory);
        }

        public Inventory? DeleteOne(string inventoryId)
        {
            var findInventory = _inventoryRepository.FindOne(inventoryId);
            if(findInventory == null) return null;
            return _inventoryRepository.DeleteOne(inventoryId);
        }

        public List<Inventory> FindAll()
        {
            return _inventoryRepository.FindAll().ToList();
        }

        public Inventory? FindOne(string inventoryId)
        {
            return _inventoryRepository.FindOne(inventoryId);
        }

        public Inventory? UpdateOne(string inventoryId, Inventory newInventory)
        {
            var findInventory = _inventoryRepository.FindOne(inventoryId);
            if(findInventory == null) return null;
            findInventory.Quantity = newInventory.Quantity;
            findInventory.Color = newInventory.Color;
            findInventory.Size = newInventory.Size;
            return _inventoryRepository.UpdateOne(findInventory);
        }
    }
}