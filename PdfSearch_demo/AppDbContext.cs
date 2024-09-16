using Microsoft.EntityFrameworkCore;

namespace PdfSearch_demo
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=.\AppUsers.db");
        }

        public DbSet<User> Users { get; set; }
    }
}
