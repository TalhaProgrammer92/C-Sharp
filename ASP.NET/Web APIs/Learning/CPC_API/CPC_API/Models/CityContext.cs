using CPC_API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CPC_API.Models
{
    public class CityContext : DbContext
    {
        public CityContext(DbContextOptions<CityContext> options) : base(options) { }

        public DbSet<City> Cities { get; set; }
    }
}