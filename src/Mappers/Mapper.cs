using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services.Mappers
{
    // Add mapper class
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<User, UserReadDto>(); // map it shape from user entity to user DTO
            CreateMap<UserReadDto, User>();
            CreateMap<UserCreateDto, User>();
            CreateMap<CategoryCreateDto, Category>();
            CreateMap<Category, CategoryCreateDto>();
            CreateMap<OrderItemCreateDto, OrderItem>();// <from, to>
            CreateMap<OrderItem, OrderItemCreateDto>();
            
            CreateMap<CheckoutDto, OrderItem>();
            CreateMap<OrderItem,CheckoutDto>();

            CreateMap<Inventory, InventoryCreateDto>();
            CreateMap<ProductCreateDto, Product>();
            CreateMap<Product, ProductCreateDto>();
            CreateMap<InventoryCreateDto, Inventory>();

        }
    }
}