using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User CreateOne(User user)
        {
            return _userRepository.CreateOne(user);
        }

        public List<User> DeleteOne(string userId)
        {
            return _userRepository.DeleteOne(userId);
        }

        public List<User> FindAll()
        {
            return _userRepository.FindAll();
        }

        public User? FindOne(string userId)
        {
            return _userRepository.FindOne(userId);
        }
        public User? UpdateOne(string userId, User newValue)
        {
            var user = _userRepository.FindOne(userId);
            if (user != null){
                user.Name = newValue.Name;
                return _userRepository.UpdateOne(user);
            }
            return null;
        }
    }
}