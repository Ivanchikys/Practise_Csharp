using Microsoft.EntityFrameworkCore;
using EveningMovies.Models;

namespace EveningMovies.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<EveningMovie> EveningMovies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EveningMovie>()
                .HasIndex(e => e.MoodTag)
                .HasDatabaseName("IX_EveningMovies_MoodTag");
        }
    }
}