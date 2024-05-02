using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<Inventory> _inventories;
        // private DatabaseContext _databaseContext;

        public InventoryRepository(DatabaseContext databaseContext)
        {
            _inventories = databaseContext.Inventories;
            // _databaseContext = databaseContext;
        }

        public Inventory? CreateOne(Inventory newInventory)
        {
            _inventories.Add(newInventory);
            return newInventory;
        }

        public Inventory? DeleteOne(string inventoryId)
        {
            var deletedInventory = FindOne(inventoryId);
            _inventories.Remove(deletedInventory!);
            return deletedInventory;
        }

        public IEnumerable<Inventory> FindAll()
        {
            return _inventories;
        }

        public Inventory? FindOne(string inventoryId)
        {
            var findInventory = _inventories.Find((item)=>item.Id == inventoryId);
            return findInventory;
        }

        public Inventory? UpdateOne(Inventory newInventory)
        {
            var inventories = _inventories.Select(inventory => {
                if(inventory.Id == newInventory.Id)
                return newInventory;
                else{
                    return inventory;
                }
            });
            _inventories = inventories.ToList();
            return newInventory;
        }
    }
}
