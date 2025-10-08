using System.ComponentModel.DataAnnotations;

namespace CodeFirstApproach.Models.Entities
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}
