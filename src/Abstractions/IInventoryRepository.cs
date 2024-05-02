
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IInventoryRepository
    {
        public IEnumerable<Inventory> FindAll();
        public Inventory? FindOne(Guid inventoryId);
        public Inventory? CreateOne(Inventory newInventory);
        public Inventory? DeleteOne(Guid inventoryId);
        public Inventory? UpdateOne(Inventory updateInventory);

    }
}