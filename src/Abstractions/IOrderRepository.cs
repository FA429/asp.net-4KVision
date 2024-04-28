

using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IOrderRepository
    {
        public List<Order> FindAll();
        public Order? FindOne(string OrderId);
        public List<Order> CreateOne([FromBody] Order order);
        public List<Order> DeleteOne(string OrderId);


    }
}