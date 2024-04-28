


using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories
{
    public class OrderRepository : IOrderRepository
    {

        private List<Order> _order;
        public OrderRepository()
        {
            _order = new DatabaseContext().order;

        }

        public List<Order> FindAll()
        {
            return _order;
        }

        public Order? FindOne(string OrderId)
        {
            var findOrder = _order.FirstOrDefault((order)=> order.Id == OrderId);
            return findOrder;

        }
        public List<Order> CreateOne([FromBody] Order order)
        {
            return _order;

        }
        public List<Order> DeleteOne(string OrderId)
        {
            return _order;

        }

    }
}