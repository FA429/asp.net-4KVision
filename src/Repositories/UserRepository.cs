using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories
{
    public class UserRepository : IUserRepository
    {
        private List<User> _users;
        public UserRepository()
        {
            _users = new DatabaseContext().Users;
        }

        public User CreateOne(User user)
        {
            _users.Add(user);
            return user;
        }

        public User? DeleteOne(string userId)
        {
            var deleteUser = FindOne(userId);
                _users.Remove(deleteUser!);
                return deleteUser; 
        }

        public List<User> FindAll()
        {
            return _users;
        }

        public User? FindOne(string userId)
        {
            var FindUser = _users.Find(user => user.Id == userId);
            return FindUser;
        }

        public User UpdateOne(User UpdatedUser)
        {
            var users = _users.Select(user=>{
                if(user.Id == UpdatedUser.Id){
                    return UpdatedUser;
                }
                return user;
            });
            _users = users.ToList();
            return UpdatedUser;
        }
    }
}