namespace sda_onsite_2_csharp_backend_teamwork.src.Entities
{
    public class User
    {
        public User(string id,string role, string name, string password, string email, string phone)
        {
            Id = id;
            Role = role;
            Name = name;
            Password = password;
            Email = email;
            Phone = phone;
        }

        public string Id { get; set; }
        public string Role { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}