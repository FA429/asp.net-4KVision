using System.Text;
using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Utils;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        private IConfiguration _config;
        private IMapper _mapper;

        public UserService(IUserRepository userRepository, IConfiguration config, IMapper mapper)
        {
            _userRepository = userRepository;
            _config = config;
            _mapper = mapper;
        }

        public UserReadDto CreateOne(UserCreateDto user)
        {
            byte[] pepper = Encoding.UTF8.GetBytes(_config["Jwt:Pepper"]!);
            PasswordUtils.HashPassword(user.Password, out string hashedPassword, pepper);
            user.Password = hashedPassword;
            User mappedUser = _mapper.Map<User>(user);
            User newUser = _userRepository.CreateOne(mappedUser);
            UserReadDto readerUser = _mapper.Map<UserReadDto>(newUser);
            return readerUser;
        }

        public bool DeleteOne(Guid userId)
        {
            var deleteUser = _userRepository.FindOne(userId);
            if (deleteUser == null) return false;
            _userRepository.DeleteOne(userId);
            return true;
        }

        public IEnumerable<UserReadDto> FindAll()
        {
            var users = _userRepository.FindAll();
            var usersRead = users.Select(user => _mapper.Map<UserReadDto>(user));
            return usersRead;

        }

        public UserReadDto? FindOne(Guid userId)
        {
            User? user = _userRepository.FindOne(userId);
            UserReadDto? userRead = _mapper.Map<UserReadDto>(user);
            return userRead;
        }

        public UserReadDto? UpdateOne(Guid userId, UserUpdateDto newValue)
        {
            var user = _userRepository.FindOne(userId);
            if (user == null) return null;
            user.Name = newValue.Name;
            user.Password = newValue.Password;
            user.Email = newValue.Email;
            user.Phone = newValue.Phone;
            _userRepository.UpdateOne(user);
            return _mapper.Map<UserReadDto>(user);
        }
    }
}