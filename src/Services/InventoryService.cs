using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services
{
    public class InventoryService : IInventoryService
    {
        private IInventoryRepository _inventoryRepository;
        private IMapper _mapper;

        public InventoryService(IInventoryRepository inventoryRepository, IMapper mapper)
        {
            _inventoryRepository = inventoryRepository;
            _mapper = mapper;
        }

        public Inventory? CreateOne(InventoryCreateDto newInventory)
        {
            Inventory? mapperInventory = _mapper.Map<Inventory>(newInventory);
            Inventory? inventory =_inventoryRepository.CreateOne(mapperInventory);
            return inventory;
        }

        public Inventory? DeleteOne(Guid inventoryId)
        {
            Inventory? findInventory = _inventoryRepository.FindOne(inventoryId);
            if(findInventory == null) return null;
            return _inventoryRepository.DeleteOne(inventoryId);
        }

        public List<Inventory> FindAll()
        {
            return _inventoryRepository.FindAll().ToList();
        }

        public Inventory? FindOne(Guid inventoryId)
        {
            List<Inventory> inventories = _inventoryRepository.FindAll().ToList();
            Inventory? isFound = inventories.Find(inventory => inventory.Id == inventoryId);
            if(isFound == null) return null;
            return _inventoryRepository.FindOne(inventoryId);
        }

        public Inventory? UpdateOne(Guid inventoryId, Inventory updateInventory)
        {
            Inventory? findInventory = _inventoryRepository.FindOne(inventoryId);
            if(findInventory == null) return null;
            findInventory.Quantity = updateInventory.Quantity;
            findInventory.Color = updateInventory.Color;
            findInventory.Size = updateInventory.Size;
            return _inventoryRepository.UpdateOne(findInventory);
        }
    }
}