using AAsignmentNimap.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AAsignmentNimap.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op) : base(op)
        {

        }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
