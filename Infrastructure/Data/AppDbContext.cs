using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class AppDbContext : DbContext
{
     public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

     public DbSet<Event> Events => Set<Event>();
    public DbSet<Order> Orders => Set<Order>();
    
    

     protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Event>(e =>
        {
            e.HasIndex(s => s.Id).IsUnique();

            
            e.HasMany(s => s.)
                .WithOne()
                .HasForeignKey(subject => subject.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            e.Navigation(s => s.).UsePropertyAccessMode(PropertyAccessMode.Field);

            e.HasMany(s => s.)
                .WithOne()
                .HasForeignKey(b => b.StudentId);
            e.Navigation(s => s.).UsePropertyAccessMode(PropertyAccessMode.Field);
        });

        modelBuilder.Entity<>(test =>
        {
            test.HasMany(t => t.)
                .WithOne()
                .HasForeignKey(r => r.)
                .OnDelete(DeleteBehavior.Cascade);
            test.Navigation(t => t.Recommendations).UsePropertyAccessMode(PropertyAccessMode.Field);
        });

       
    }


}