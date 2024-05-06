
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IInventoryService
    {
        public IEnumerable<InventoryReadDto> FindAll();
        public InventoryReadDto? FindOne(Guid inventoryId);
        public InventoryReadDto? CreateOne(InventoryCreateDto newInventory);
        public bool DeleteOne(Guid inventoryId);
        public InventoryReadDto? UpdateOne(Guid inventoryId, InventoryUpdateDto updateInventory);
    }
}