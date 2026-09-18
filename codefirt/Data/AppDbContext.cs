using codefirt.Models;
using Microsoft.EntityFrameworkCore;

namespace codefirt.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Desenvolvedora> Desenvolvedoras => Set<Desenvolvedora>();
        public DbSet<Game> Games => Set<Game>();
        public DbSet<Genero> Generos => Set<Genero>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Desenvolvedora>()
                .HasMany(d => d.Games)
                .WithOne(d => d.Desenvolvedora)
                .HasForeignKey(d => d.DesenvolvedoraId);

            modelBuilder.Entity<Game>()
                .HasMany(g => g.Generos)
                .WithMany(g => g.Games);
        }

    }
}
