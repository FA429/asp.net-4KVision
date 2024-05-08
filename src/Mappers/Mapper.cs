using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<User, UserReadDto>(); // map it shape from user entity to user DTO
            CreateMap<UserCreateDto, User>();

            CreateMap<CategoryCreateDto, Category>();
            CreateMap<Category, CategoryReadDto>();
            CreateMap<CategoryUpdateDto, Category>()
            .ForAllMembers(opts => opts.Condition((src, dest, srcProperty) => srcProperty != null));


            CreateMap<OrderItemCreateDto, OrderItem>();// <from, to>

            CreateMap<ProductCreateDto, Product>();
            CreateMap<Product, ProductCreateDto>();

            CreateMap<Product, ProductReadDto>();
            CreateMap<ProductUpdateDto, Product>();

            CreateMap<InventoryCreateDto, Inventory>();
            CreateMap<Inventory, InventoryReadDto>();
        }
    }
}