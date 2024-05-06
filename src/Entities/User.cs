using System.ComponentModel.DataAnnotations;

namespace sda_onsite_2_csharp_backend_teamwork.src.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required,MaxLength]
        public string Phone { get; set; }
        public List<Order>? Order { get; set; }

    }
}