using EcommerceBackend.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EcommerceBackend.Data
{
    public class AppDbContext : IdentityDbContext<User>
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
        public DbSet<User> Admins { get; set; }
        public DbSet<Luxury> Luxuries { get; set; }
        public DbSet<HeroSection> HeroSections { get; set; }
        public DbSet<InstagramPost> InstagramPosts { get; set; }
        public DbSet<Pret> Prets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure entity relationships and constraints
            modelBuilder.Entity<User>();

            // HeroSection configuration
            modelBuilder.Entity<HeroSection>(entity =>
            {
                entity.HasKey(e => e.Id);   // Primary key
                
                entity.Property(e => e.Title)   // Title of the hero section. It can't be null and has a maximum length of 200 characters.
                    .IsRequired().HasMaxLength(200);
                
                entity.Property(e => e.Subtitle).HasMaxLength(500); // Subtitle of the hero section. It can be null, with a maximum length of 500 characters.

                entity.Property(e => e.BannerImageBase64)   // Base64 encoded image for the hero section banner. It can't be null and is stored as nvarchar(max).
                    .IsRequired();
                
                entity.Property(e => e.ImageContentType)    // Content type of the image (e.g., "image/jpeg"). It can't be null and has a maximum length of 30 characters.
                    .IsRequired().HasMaxLength(100);

                entity.Property(e => e.CreatedAt)   // Creation timestamp for the hero section. It defaults to the current UTC date and time.
                    .HasDefaultValueSql("GETUTCDATE()");

                entity.HasIndex(e => e.CreatedAt);  // Index on CreatedAt for efficient querying
            });

            // Product Configuration
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.OriginalPrice)
                    .HasPrecision(18, 2);
                
                entity.Property(e => e.SalePrice)
                    .HasPrecision(18, 2);
            });

            // Featured Product configuration
            modelBuilder.Entity<FeaturedProduct>(entity =>
            {
                entity.Property(e => e.OriginalPrice)
                    .HasPrecision(18, 2);

                entity.Property(e => e.SalePrice)
                    .HasPrecision(18, 2);
            });

            // Order configuration
            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Orders");   // Explicit table name
                
                entity.HasKey(o => o.Id);   // Primary key

                entity.Property(o => o.OrderNumber) // Unique order number, generated as a substring of a GUID
                    .IsRequired();
                
                entity.Property(o => o.OrderDate)   // Order date, defaults to the current UTC date and time
                    .IsRequired();
                
                entity.Property(o => o.CustomerName)    // Customer's name, required and has a maximum length of 100 characters
                    .IsRequired()
                    .HasMaxLength(100);
                
                entity.Property(o => o.CustomerEmail)   // Customer's email, required and must be a valid email address
                    .IsRequired()
                    .HasMaxLength(100);
                
                entity.Property(o => o.CustomerPhone)   // Customer's phone number, required and has a maximum length of 15 characters
                    .HasMaxLength(15);
                
                entity.Property(o => o.ShippingAddress) // Shipping address, required and has a maximum length of 500 characters
                    .IsRequired()
                    .HasMaxLength(500);
                
                entity.Property(o => o.PaymentMethod)   // Payment method, defaults to "CashOnDelivery"
                    .IsRequired();
                
                entity.Property(o => o.Subtotal)    // Subtotal amount, stored as decimal with 18 digits and 2 decimal places
                    .HasColumnType("decimal(18,2)")
                    .IsRequired();
                
                entity.Property(o => o.ShippingCost)    // Shipping cost, stored as decimal with 18 digits and 2 decimal places
                    .HasColumnType("decimal(18,2)")
                    .IsRequired();
                
                entity.Property(o => o.Total)   // Total amount, stored as decimal with 18 digits and 2 decimal places
                    .HasColumnType("decimal(18,2)")
                    .IsRequired();
                
                entity.Property(o => o.Status)  // Order status, defaults to "Pending"
                    .IsRequired();

                // Configure the one-to-many relationship
                entity.HasMany(o => o.OrderItems)   // i.e. An order can have multiple order items
                      .WithOne(i => i.Order)
                      .HasForeignKey(i => i.OrderId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // OrderItem configuration
            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.ToTable("OrderItems");   // Explicit table name

                entity.HasKey(i => i.Id);   // Primary key

                entity.Property(i => i.ProductId)   // Product ID, required and represents the unique identifier for the product
                    .IsRequired();
                
                entity.Property(i => i.ProductName) // Product name, required and has a maximum length of 200 characters
                    .IsRequired();
                
                entity.Property(i => i.Price)   // Price of the product, stored as decimal with 18 digits and 2 decimal places
                    .HasColumnType("decimal(18,2)")
                    .IsRequired();
                
                entity.Property(i => i.Quantity)    // Quantity of the product in the order item, required and must be a positive integer
                    .IsRequired();
            });

            // InstagramPost configuration
            modelBuilder.Entity<InstagramPost>(entity =>
            {
                entity.ToTable("InstagramPosts"); // Explicit table name
                
                entity.HasKey(e => e.Id);   // Primary key

                entity.Property(e => e.ImageUrl)    // URL of the Instagram post image, required and has a maximum length of 500 characters
                    .IsRequired();
                
                entity.Property(e => e.InstagramLink)   // Link to the Instagram post, required and has a maximum length of 500 characters
                    .IsRequired();
                
                entity.Property(e => e.ImageContentType)    // Content type of the image (e.g., "image/jpeg"), required and has a maximum length of 100 characters
                    .IsRequired();
            });
        }
    }
}
