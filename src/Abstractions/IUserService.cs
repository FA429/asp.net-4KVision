using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IUserService
    {
        public IEnumerable<UserReadDto> FindAll(int limit, int offset);
        public UserReadDto? FindOne(Guid userId);
        public UserReadDto SignUp(UserCreateDto user);
        public string? Login(UserLogInDto user);
        public bool DeleteOne(Guid userId);
        public UserReadDto? UpdateOne(Guid userId, UserUpdateDto user);
    }
}