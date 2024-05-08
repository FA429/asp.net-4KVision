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

        public void DeleteOne(Guid inventoryId)
        {
            var deletedInventory = FindOne(inventoryId);
            _inventories.Remove(deletedInventory!);
            _databaseContext.SaveChanges();
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
            _inventories.Update(updateInventory);
            _databaseContext.SaveChanges();
            return updateInventory;
        }
    }
}