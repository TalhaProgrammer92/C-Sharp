using System.ComponentModel.DataAnnotations;

namespace EcommerceBackend.DTOs
{
    public class UserDTO
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
