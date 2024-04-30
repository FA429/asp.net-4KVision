

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IOrderRepository
    {
        public DbSet<Order> FindAll();
        public Order? FindOne(Guid OrderId);
        public Order CreateOne([FromBody] Order order);
        public Order? DeleteOne(Guid OrderId);


    }
}