
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IInventoryService
    {
        public List<Inventory> FindAll();
        public Inventory? FindOne(Guid inventoryId);
        public Inventory? CreateOne(InventoryCreateDto newInventory);
        public Inventory? DeleteOne(Guid inventoryId);
        public Inventory? UpdateOne(Guid inventoryId, Inventory newInventory);
    }
}