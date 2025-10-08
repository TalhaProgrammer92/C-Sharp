using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproach.Models
{
    public class CarContext : DbContext
    {
        // Constructor
        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {
        }

        // DbSet for Cars
        public DbSet<Entities.Car> Cars { get; set; }
    }
}
