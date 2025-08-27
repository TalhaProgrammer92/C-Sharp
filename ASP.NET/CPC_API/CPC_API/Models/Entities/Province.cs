using System.ComponentModel.DataAnnotations.Schema;

namespace CPC_API.Models.Entities
{
    public class Province : BaseEntity
    {
        // Attributes
        public required string Name { get; set; }
        //[ForeignKey("Country")]
        public int CountryId { get; set; }
    }
}
