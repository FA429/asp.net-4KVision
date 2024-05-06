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

        public InventoryReadDto? CreateOne(InventoryCreateDto newInventory)
        {
            Inventory? mapperInventory = _mapper.Map<Inventory>(newInventory);
            Inventory? inventory = _inventoryRepository.CreateOne(mapperInventory);
            InventoryReadDto? readInventory = _mapper.Map<InventoryReadDto>(inventory);
            return readInventory;
        }

        public bool DeleteOne(Guid inventoryId)
        {
            Inventory? findInventory = _inventoryRepository.FindOne(inventoryId);
            if (findInventory == null) return false;
            _inventoryRepository.DeleteOne(inventoryId);
            return true;
        }

        public IEnumerable<InventoryReadDto> FindAll()
        {
            IEnumerable<Inventory>? inventories = _inventoryRepository.FindAll();
            IEnumerable<InventoryReadDto> readInventories = inventories.Select(item => _mapper.Map<InventoryReadDto>(item));
            return readInventories;

        }

        public InventoryReadDto? FindOne(Guid inventoryId)
        {
            IEnumerable<Inventory> inventories = _inventoryRepository.FindAll();
            Inventory? isFound = inventories.FirstOrDefault(inventory => inventory.Id == inventoryId);
            if (isFound == null) return null;
            var inventory =_inventoryRepository.FindOne(inventoryId);
            return _mapper.Map<InventoryReadDto>(inventory);
        }

        public InventoryReadDto? UpdateOne(Guid inventoryId, InventoryUpdateDto updateInventory)
        {
            Inventory? inventory = _inventoryRepository.FindOne(inventoryId);
            if (inventory == null) return null;
            inventory.Quantity = updateInventory.Quantity;
            inventory.Color = updateInventory.Color;
            inventory.Size = updateInventory.Size;
            _inventoryRepository.UpdateOne(inventory);
            return _mapper.Map<InventoryReadDto>(inventory);
        }
    }
}