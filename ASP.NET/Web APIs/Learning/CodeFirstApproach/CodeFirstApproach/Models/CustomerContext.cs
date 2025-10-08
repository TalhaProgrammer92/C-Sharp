using CodeFirstApproach.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproach.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
