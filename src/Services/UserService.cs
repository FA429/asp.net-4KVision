using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        private IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public User CreateOne(User user)
        {
            return _userRepository.CreateOne(user);
        }

        public User? DeleteOne(string userId)
        {
            var deleteUser = _userRepository.FindOne(userId);
            if (deleteUser == null)
            {
                return null;
            }
            else
            {
                return _userRepository.DeleteOne(userId);
            }
        }

        public List<UserReadDto> FindAll()
        {
            var users = _userRepository.FindAll();
            var usersRead = users.Select(user => _mapper.Map<UserReadDto>(user));
            return usersRead.ToList();

        }

        public UserReadDto? FindOne(string userId)
        {
            User? user = _userRepository.FindOne(userId);
            UserReadDto? userRead = _mapper.Map<UserReadDto>(user);
            return userRead;
        }
        public User? UpdateOne(string userId, User newValue)
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