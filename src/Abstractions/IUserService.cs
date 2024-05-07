using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IUserService
    {
        // change the type from user to UserReadDto
        public IEnumerable<UserReadDto> FindAll();
        public UserReadDto? FindOne(Guid userId);
        public UserReadDto SignUp(UserCreateDto user);
        public string? Login(UserLogInDto user);
        public bool DeleteOne(Guid userId);
        public UserReadDto? UpdateOne(Guid userId, UserUpdateDto user);
    }
}