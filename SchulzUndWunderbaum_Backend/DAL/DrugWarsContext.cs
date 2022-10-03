using Microsoft.EntityFrameworkCore;
using SchulzUndWunderbaum_Backend.Models.DrugWars;

namespace SchulzUndWunderbaum_Backend.DAL
{
    public class DrugWarsContext : DbContext
    {

        public DrugWarsContext(DbContextOptions<DrugWarsContext> options) : base(options)
        {
        }

        public DbSet<Player> Player { get; set; }
        public DbSet<HighScore> HighScores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().ToTable("Player");
            modelBuilder.Entity<HighScore>().ToTable("HighScore");
        }
    }
}

