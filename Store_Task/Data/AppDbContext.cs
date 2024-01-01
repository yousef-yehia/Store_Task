using Microsoft.EntityFrameworkCore;
using Store_Task.Models;

namespace Store_Task.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
           .HasOne(b => b.Category)
           .WithMany(a => a.Products)
           .HasForeignKey(b => b.CategoryId);
        }

    }
}
