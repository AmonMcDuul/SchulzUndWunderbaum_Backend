using Microsoft.EntityFrameworkCore;
using SchulzUndWunderbaum_Backend.Models.DrugWars;

namespace SchulzUndWunderbaum_Backend.DAL
{
    public class DrugWarsContext : DbContext
    {

        public DrugWarsContext(DbContextOptions<DrugWarsContext> options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<HighScore> HighScores { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<Player> Armors { get; set; }
        public DbSet<Player> Weapons { get; set; }
        public DbSet<Player> Items { get; set; }
        public DbSet<Player> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().ToTable("Player");
            modelBuilder.Entity<HighScore>().ToTable("HighScore");
            modelBuilder.Entity<Drug>().ToTable("Drug");
            modelBuilder.Entity<Armor>().ToTable("Armor");
            modelBuilder.Entity<Weapon>().ToTable("Weapon");
            modelBuilder.Entity<Item>().ToTable("Item");
            modelBuilder.Entity<Location>().ToTable("Location");
        }
    }
}

