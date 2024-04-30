<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
=======
using System.Text;
>>>>>>> 798687c12f5f5c33fa39b542377445515a851f9d
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Utils;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        private IConfiguration _config;

        public UserService(IUserRepository userRepository, IConfiguration config)
        {
            _userRepository = userRepository;
            _config = config;
        }

        public User CreateOne(User user)
        {
            byte[] pepper = Encoding.UTF8.GetBytes(_config["Pass:Pepper"]!);
            PasswordUtils.HashPassword(user.Password, out string hashedPassword, pepper);
            user.Password = hashedPassword;
            return _userRepository.CreateOne(user);
        }

        public User? DeleteOne(Guid userId)
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

        public DbSet<User> FindAll()
        {
            return _userRepository.FindAll();
        }

        public User? FindOne(Guid userId)
        {
            return _userRepository.FindOne(userId);
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