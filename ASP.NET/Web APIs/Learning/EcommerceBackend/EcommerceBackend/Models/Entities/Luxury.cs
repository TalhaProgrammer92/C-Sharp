using Microsoft.EntityFrameworkCore;

namespace EcommerceBackend.Models.Entities
{
    public class Luxury : Product
    {
        public string Note {  get; set; }
    }
}
