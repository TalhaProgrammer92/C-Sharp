namespace CPC_API.Models.Entities
{
    public class City : BaseEntity
    {
        // Attributes
        public required string Name { get; set; }
        public int ProvinceId { get; set; }
        public int CountryId { get; set; }
    }
}
