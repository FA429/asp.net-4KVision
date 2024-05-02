using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IUserService
    {
        // change the type from user to UserReadDto
        public List<UserReadDto> FindAll();
        public UserReadDto? FindOne(string userId);
        public User CreateOne(User user);
        public User? DeleteOne(string userId);
        public User? UpdateOne(string userId, User user);
    }
}