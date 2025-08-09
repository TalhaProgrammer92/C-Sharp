using EcommerceBackend.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EcommerceBackend.Data
{
    public class AppDbContext : IdentityDbContext<Admin>
    {
        // Cosntructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Adding DbSets for entites
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<FeaturedProduct> FeaturedProducts { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Luxury> Luxuries { get; set; }
        public DbSet<HeroSection> HeroSections { get; set; }
        public DbSet<InstagramPost> InstagramPosts { get; set; }
        public DbSet<Pret> Prets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Configure entity relationships and constraints here if needed
            modelBuilder.Entity<HeroSection>(entity =>
            {
                entity.HasKey(e => e.Id);
                
                entity.Property(e => e.Title)
                    .IsRequired().HasMaxLength(200);
                
                entity.Property(e => e.Subtitle).HasMaxLength(500);
                
                entity.Property(e => e.BannerImageBase64)
                    .IsRequired();
                
                entity.Property(e => e.ImageContentType)
                    .IsRequired().HasMaxLength(100);

                entity.Property(e => e.CreatedAt)
                    .HasDefaultValueSql("GETUTCDATE()");

                entity.HasIndex(e => e.CreatedAt);
            });
        }
    }
}
