using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IUserService
    {
        public List<User> FindAll();
        public User? FindOne(Guid userId);
        public User CreateOne(User user);
        public User? DeleteOne(Guid userId);
        public User? UpdateOne(Guid userId, User user);
    }
}