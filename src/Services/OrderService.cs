

using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
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
        private IOrderItemRepository _orderItemRepository;
        private IInventoryRepository _inventoryRepository;
        private IProductRepository _productRepository;
        private IConfiguration _config;
        private IMapper _mapper;



        public OrderServices(IOrderRepository orderRepository, IConfiguration config, IMapper mapper, IOrderItemRepository orderItemRepository, IInventoryRepository inventoryRepository, IProductRepository productRepository)
        {
            _orderRepository = orderRepository;
            _config = config;
            _mapper = mapper;
            _orderItemRepository = orderItemRepository;
            _inventoryRepository = inventoryRepository;
            _productRepository = productRepository;

        }

        public IEnumerable<Order> FindAll()
        {
            return _orderRepository.FindAll();

        }

        public Order? FindOne(Guid OrderId)
        {
            return _orderRepository.FindOne(OrderId); ;

        }

        public async Task<Order> CreateOne(List<CheckoutDto> checkoutOrderItems)
        {


            var order = new Order();
            // order.UserId = new Guid("f0098fdc-10fb-4a4b-8caa-84713c621b34");

            // Create the order and wait for it to be created
            // order = await _orderRepository.CreateOne(order);

            foreach (var item in checkoutOrderItems)
            {
                var orderItem = new OrderItem();



                // Select cloer ,size productId from inventory where size.order= size and cloer= cloer and productId= productId
                var findInventory = _inventoryRepository.FindAll().FirstOrDefault((inv) => inv.Size == item.Size && inv.Color == item.Color && inv.ProductId == item.ProductId);
                orderItem.InventoryId = findInventory.Id;
                orderItem.Quantity = item.Quantity;
                orderItem.TotalPrice = item.TotalPrice;
                orderItem.OrderId = order.Id; // Set OrderId after order is created
                await _orderItemRepository.CreateOne(orderItem);
            }
            order.UserId = Guid.NewGuid();
            order = await _orderRepository.CreateOne(order);
            return order;



        }




        /*
                  1. create order
                  2. loop thro the checkedoutOItems and create OrderItem
                  3. done.
                  */



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
