using Apex.GameZone.API.ViewModels.CashRegister;
using Apex.GameZone.Data.Entities;
using Apex.GameZone.Data.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Apex.GameZone.Data.DAO;

public class MainDbContext : DbContext
{
    public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
    {
    }

    public DbSet<GameZoneEntity> GameZones { get; set; }
    public DbSet<CashoutEntity> Cashouts { get; set; }

    public DbSet<SectionEntity> Sections { get; set; }
    public DbSet<ItemEntity> Items { get; set; }
    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<CheckoutEntity> Checkouts { get; set; }
    public DbSet<ItemCheckoutEntity> ItemCheckoutMapping { get; set; }
    public DbSet<ProductCheckoutEntity> ProductCheckoutMapping { get; set; }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var entries = ChangeTracker.Entries().Where(e =>
            e.Entity is BaseEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));

        foreach (var entry in entries)
        {
            ((BaseEntity)entry.Entity).ModifiedDate = DateTime.UtcNow;

            if (entry.State == EntityState.Added) ((BaseEntity)entry.Entity).AddedDate = DateTime.UtcNow;
        }

        return base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyGlobalFilter("IsDeleted", false);

        modelBuilder.Seed();
    }
}