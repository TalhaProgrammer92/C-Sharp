using CPC_API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CPC_API.Models
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options) : base(options) {}

        public DbSet<Country> Countries { get; set; }
    }
}
