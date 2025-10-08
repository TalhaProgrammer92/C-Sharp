using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Models.Context
{
    public class Customer : DbContext
    {
        public Customer(DbContextOptions<Customer> options) : base(options) { }

        public DbSet<Entities.Customer> Customers { get; set; }
    }
}
