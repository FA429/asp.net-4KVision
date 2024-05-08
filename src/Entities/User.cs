using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Enums;

namespace sda_onsite_2_csharp_backend_teamwork.src.Entities
{
    [Index(nameof(Email), IsUnique = true)] // Index is to Search by email faster. 
    public class User
    {
        public Guid Id { get; set; }
        public Role Role { get; set; } = Role.Customer;
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        public List<Order>? Order { get; set; } // Navigation Property

    }
}