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
        private List<CheckoutDto> _CheckoutDto;
        private DatabaseContext _db;

        public OrderRepository(DatabaseContext databaseContext)
        {
            _order = databaseContext.Orders;
            _db = databaseContext;
        }

        public IEnumerable<Order> FindAll()
        {
            return _order;
        }

        public Order? FindOne(Guid OrderId)
        {
            var findOrder = _order.FirstOrDefault((order) => order.Id == OrderId);
            return findOrder;

        }
        public CheckoutDto CreateOne([FromBody] List<CheckoutDto>  CheckoutDto)
        {
            foreach (var item in CheckoutDto)
            {
                
            
            _CheckoutDto.Add(item);
            _db.SaveChanges();
            return item;

            
            
            }
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

