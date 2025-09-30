using Microsoft.EntityFrameworkCore;
using Product_Layered_Architecture.Models.Entities;

namespace Product_Layered_Architecture.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Product> Products { get; set; }
    }
}
