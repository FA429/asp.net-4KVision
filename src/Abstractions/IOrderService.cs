

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IOrderService
    {
        public IEnumerable<Order> FindAll();
        public Order? FindOne(Guid OrderId);
        public Order CreateOne(List<CheckoutDto> order, string userId);
        public Order? DeleteOne(Guid OrderId);

    }
}