using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IUserService
    {
        // change the type from user to UserReadDto
        public List<UserReadDto> FindAll();
        public UserReadDto? FindOne(Guid userId);
        public UserReadDto CreateOne(UserCreateDto user);
        public UserReadDto? DeleteOne(Guid userId);
        public User? UpdateOne(Guid userId, User user);
    }
}