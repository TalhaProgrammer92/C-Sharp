namespace CPC_API.Models.Entities
{
    public class Country : BaseEntity
    {
        // Attributes
        public required string Name { get; set; }
        public required string Code { get; set; }
    }
}
