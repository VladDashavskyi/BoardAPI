using BoardAPI.DAL.Model;
using Microsoft.EntityFrameworkCore;

namespace BoardAPI.DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Announcement> Ads { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Announcement>().HasNoKey();
        }
    }
}
