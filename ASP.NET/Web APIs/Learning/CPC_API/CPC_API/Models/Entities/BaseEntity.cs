using System.ComponentModel.DataAnnotations;

namespace CPC_API.Models.Entities
{
    public class BaseEntity
    {
        // Attributes
        [Key]
        public int Id { get; set; }
        public DateTime ModificationDate { get; set; } = DateTime.Now;
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
