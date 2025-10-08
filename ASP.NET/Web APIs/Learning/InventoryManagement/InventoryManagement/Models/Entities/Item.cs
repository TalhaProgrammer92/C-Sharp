using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models.Entities
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public string CompanyName { get; set; }
        public string? Description { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
