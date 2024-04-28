using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IUserService
    {
        public List<User> FindAll();
        public User? FindOne(string userId);
        public User CreateOne(User user);
        public List<User> DeleteOne(string userId);
        public User? UpdateOne(string userId, User user);
    }
}