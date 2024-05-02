using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories
{
    public class OrderRepository : IOrderRepository
    {

        private DbSet<Order> _order;
        private DatabaseContext _db;
        private DbSet<OrderItem> _orderItems;

        public OrderRepository(DatabaseContext databaseContext)
        {
            _order = databaseContext.Orders;
            _db = databaseContext;
            _orderItems=databaseContext.OrderItems;

        }

        public IEnumerable<Order> FindAll()
        {
            return _order;
        }

        public Order? FindOne(Guid OrderId)
        {
            var findOrder = _order.Find(OrderId);
            return findOrder;

        }
        public OrderItem CreateOne(OrderItem orderItem)
        {
          
            
            _orderItems.Add(orderItem);
            _db.SaveChanges();
            return orderItem;

        }
        // public Order? DeleteOne(Guid orderId)
        // {

        //     var deleteOrder = _order.Find((order) => order.Id == OrderId);
        //         _order.Remove(deleteOrder!);
        //         return deleteOrder;

        //     }
        public Order? DeleteOne(Guid orderId)
        {
            var deleteOrder = FindOne(orderId);
            _order.Remove(deleteOrder!);
            _db.SaveChanges();

            return deleteOrder;
        }



    }

}

