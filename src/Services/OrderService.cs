

using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Repositories;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services
{
    public class OrderServices : IOrderService
    {
        private IOrderRepository _orderRepository;
        private IConfiguration _config;
        private IMapper _mapper;



        public OrderServices(IOrderRepository orderRepository, IConfiguration config ,IMapper mapper)
        {
            _orderRepository = orderRepository;
            _config = config;
            _mapper = mapper;

        }

        public IEnumerable<Order> FindAll()
        {
            return _orderRepository.FindAll();

        }

        public Order? FindOne(Guid OrderId)
        {
            return _orderRepository.FindOne(OrderId); ;

        }

        public Order CreateOne(List<OrderItem> orderItem)
        {
            //1. fix mismatch of data type of order 
            // 2. go to Irepo, fix for data type, it is not CheckoutDto, it should be orderItem 
      var mappedOrder = _mapper.Map<OrderItem>(orderItem);
      var newOrder = _orderRepository.CreateOne(mappedOrder);
    return new O
      

            
/*
          1. create order
          2. loop thro the checkedoutOItems and create OrderItem
          3. done.

          inside order, there will be a list of order item 
          get the list of order items, then loop through it and create OrderItem
          */


        }

        public Order? DeleteOne(Guid OrderId)
        {
            var deleteOrder = _orderRepository.FindOne(OrderId);
            if (deleteOrder == null)
            {
                return null;
            }
            else
            {
                return _orderRepository.DeleteOne(OrderId);
            }


        }
    }
}