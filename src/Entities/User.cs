namespace sda_onsite_2_csharp_backend_teamwork.src.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Role { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}