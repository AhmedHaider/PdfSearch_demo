using Microsoft.EntityFrameworkCore;

namespace PdfSearch_demo
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=.\AppUsers.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();
        }

        public DbSet<User> Users { get; set; }
    }
}
