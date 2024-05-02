using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions;

    public interface IUserRepository
    {
    public IEnumerable<User> FindAll();
    public User? FindOne(Guid userId);
    public User CreateOne(User user);
    public User? DeleteOne(Guid userId);
    public User UpdateOne(User user);

    }