using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace EcommerceBackend.Models.Entities
{
    public class User : IdentityUser
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public required string Password { get; set; }
    }
}
