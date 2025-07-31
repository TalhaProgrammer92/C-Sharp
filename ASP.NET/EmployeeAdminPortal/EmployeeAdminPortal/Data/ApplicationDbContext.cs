using EmployeeAdminPortal.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor that accepts DbContextOptions
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        // DbSet for Employee entity
        public DbSet<Employee> Employees { get; set; }
    }
}
