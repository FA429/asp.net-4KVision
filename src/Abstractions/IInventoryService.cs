
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IInventoryService
    {
        public List<Inventory> FindAll();
        public Inventory? FindOne(string inventoryId);
        public Inventory? CreateOne(Inventory newInventory);
        public Inventory? DeleteOne(string inventoryId);
    }
}