using BikeStores;
using BikeStores.Models;
using Microsoft.EntityFrameworkCore;

public class BikeStoresContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }

    public DbSet<Store> Stores { get; set; }
    public DbSet<Staff> Staffs { get; set; }

    public DbSet<Product> Products { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Stock> Stocks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=3MOELJO\\SQLEXPRESS;Database=BikeStoresCodeFirst;Trusted_Connection=True;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrderItem>()
            .HasKey(o => new { o.OrderId, o.ItemId });

        modelBuilder.Entity<Stock>()
            .HasKey(s => new { s.StoreId, s.ProductId });

        modelBuilder.Entity<Staff>()
            .HasOne(s => s.Manager)
            .WithMany(s => s.Subordinates)
            .HasForeignKey(s => s.ManagerId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Order>()
            .HasOne(o => o.Store)
            .WithMany(s => s.Orders)
            .HasForeignKey(o => o.StoreId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Order>()
            .HasOne(o => o.Staff)
            .WithMany(s => s.Orders)
            .HasForeignKey(o => o.StaffId)
            .OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<OrderItem>()
      .HasKey(o => new { o.OrderId, o.ItemId });

        modelBuilder.Entity<Stock>()
            .HasKey(s => new { s.StoreId, s.ProductId });

        modelBuilder.Entity<Staff>()
            .HasOne(s => s.Manager)
            .WithMany(s => s.Subordinates)
            .HasForeignKey(s => s.ManagerId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Order>()
            .HasOne(o => o.Store)
            .WithMany(s => s.Orders)
            .HasForeignKey(o => o.StoreId)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Product>()
            .Property(p => p.ListPrice)
            .HasPrecision(10, 2);

        modelBuilder.Entity<OrderItem>()
            .Property(o => o.Discount)
            .HasPrecision(4, 2);
        modelBuilder.Entity<Order>()
            .HasOne(o => o.Staff)
            .WithMany(s => s.Orders)
            .HasForeignKey(o => o.StaffId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}