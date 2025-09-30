using InventoryManagement.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Models.Context
{
    public class Item : DbContext
    {
        public Item(DbContextOptions<Item> options) : base(options)
        {
            
        }

        public DbSet<Entities.Item> Items { get; set; }
    }
}
