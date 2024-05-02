namespace sda_onsite_2_csharp_backend_teamwork.src.DTOs
{
    public class UserReadDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
    public class UserCreateDto
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}