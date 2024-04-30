using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IOrderItemService
    {
        public DbSet<OrderItem> FindAll();
        public OrderItem? FindOne(Guid orderItemId);
        public OrderItem CreateOne( OrderItem newOrderItem);
        public OrderItem? DeleteOne(Guid orderItemId);
        public OrderItem? UpdateOne(Guid orderItemId, OrderItem newValue);
    }
}
