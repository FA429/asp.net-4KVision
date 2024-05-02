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
            UserReadDto ReaderUser = _mapper.Map<UserReadDto>(newUser);
            return ReaderUser;
        }

        public UserReadDto? DeleteOne(Guid userId)
        {
            var deleteUser = _userRepository.FindOne(userId);
            if (deleteUser == null)
            {
                return null;
            }
            else
            { 

                var deletedUser = _userRepository.DeleteOne(userId);
                var ReaderUser = _mapper.Map<UserReadDto>(deletedUser);
                return ReaderUser;
            }
        }

        public List<UserReadDto> FindAll()
        {
            var users = _userRepository.FindAll();
            var usersRead = users.Select(user => _mapper.Map<UserReadDto>(user));
            return usersRead.ToList();

        }

        public UserReadDto? FindOne(Guid userId)
        {
            User? user = _userRepository.FindOne(userId);
            UserReadDto? userRead = _mapper.Map<UserReadDto>(user);
            return userRead;
        }

        public User? UpdateOne(Guid userId, User newValue)
        {
            var user = _userRepository.FindOne(userId);
            if (user != null)
            {
                user.Name = newValue.Name;
                return _userRepository.UpdateOne(user);
            }
            return null;
        }
    }
}