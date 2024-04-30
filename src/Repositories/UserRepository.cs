using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories
{
    public class UserRepository : IUserRepository
    {
        private DbSet<User> _users;
        public UserRepository(DatabaseContext databaseContext)
        {
            _users = databaseContext.Users;
        }

        public User CreateOne(User user)
        {
            _users.Add(user);
            return user;
        }

        public User? DeleteOne(Guid userId)
        {
            var deleteUser = FindOne(userId);
            _users.Remove(deleteUser!);
            return deleteUser;
        }

        public IEnumerable<User> FindAll()
        {
            return _users;
        }

        public User? FindOne(Guid userId)
        {
            var FindUser = _users.FirstOrDefault(user => user.Id == userId);
            return FindUser;
        }

        public User UpdateOne(User UpdatedUser)
        {
            // _users = _users.Select(user =>
            // {
            //     if (user.Id == UpdatedUser.Id)
            //     {
            //         return UpdatedUser;
            //     }
            //     return user;
            // });
            _users.Update(UpdatedUser);
            return UpdatedUser;
        }
    }
}