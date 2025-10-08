using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models.Entities
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Contact { get; set; }

        [Required]
        public int ItemId { get; set; }
    }
}
