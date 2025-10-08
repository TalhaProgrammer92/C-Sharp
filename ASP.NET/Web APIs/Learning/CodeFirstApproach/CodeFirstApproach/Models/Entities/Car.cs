using System.ComponentModel.DataAnnotations;

namespace CodeFirstApproach.Models.Entities
{
    public class Car
    {
        // Attributes
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Color { get; set; }
        public required string Model { get; set; }
        public int Price { get; set; }
    }
}
