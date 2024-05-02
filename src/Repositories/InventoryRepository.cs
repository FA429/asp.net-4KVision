using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories
{
    public class InventoryRepository : IInventoryRepository
    {
        private DbSet<Inventory> _inventories;
        private DatabaseContext _databaseContext;

        public InventoryRepository(DatabaseContext databaseContext)
        {
            _inventories = databaseContext.Inventories;
            _databaseContext = databaseContext;
        }

        public Inventory? CreateOne(Inventory newInventory)
        {
            _inventories.Add(newInventory);
            _databaseContext.SaveChanges();
            return newInventory;
        }

        public Inventory? DeleteOne(Guid inventoryId)
        {
            var deletedInventory = FindOne(inventoryId);
            _inventories.Remove(deletedInventory!);
            _databaseContext.SaveChanges();
            return deletedInventory;
        }

        public IEnumerable<Inventory> FindAll()
        {
            return _inventories;
        }

        public Inventory? FindOne(Guid inventoryId)
        {
            var findInventory = _inventories.Find(inventoryId);
            return findInventory;
        }

        public Inventory? UpdateOne(Inventory updateInventory)
        {
            // var inventories = _inventories.Select(inventory =>
            // {
            //     if (inventory.Id == updateInventory.Id)
            //         return updateInventory;
            //     else
            //     {
            //         return inventory;
            //     }
            // });
            // _inventories = inventories.ToList();
            return updateInventory;
        }
    }
}
