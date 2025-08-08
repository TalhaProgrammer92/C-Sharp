using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace EcommerceBackend.Models
{
    public class Admin : IdentityUser
    {
        [Required]
        public string? Name { get; set; }
    }
}
