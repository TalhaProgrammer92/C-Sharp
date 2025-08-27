using CPC_API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CPC_API.Models
{
    public class ProvinceContext : DbContext
    {
        public ProvinceContext(DbContextOptions<ProvinceContext> options) : base(options) { }

        public DbSet<Province> Provinces { get; set; }
    }
}
