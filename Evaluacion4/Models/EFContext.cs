using Microsoft.EntityFrameworkCore;

namespace Evaluacion4.Models
{
    public class EFContext : DbContext
    {
        private const string ConnectionString = "server=localhost;port=3306;database=automotriz_db;user=root;password=;Connect Timeout=5;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConnectionString,
                new MySqlServerVersion(new Version(8, 0, 11)));
        }

        public DbSet<Automotora> Automotoras { get; set; }
        public DbSet<Auto> Autos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Automotora>().HasKey(i => i.Id);
            modelBuilder.Entity<Auto>().HasKey(j => j.Id);

            modelBuilder.Entity<Auto>()
                .HasOne<Automotora>(s => s.Automotora)
                .WithMany(g => g.Autos)
                .HasForeignKey(c => c.AutomotoraId);

            modelBuilder.Entity<Auto>().Property(s => s.AutomotoraId).IsRequired();
            modelBuilder.Entity<Auto>().Property(s => s.Modelo).IsRequired();
            modelBuilder.Entity<Auto>().Property(s => s.Cantidad).IsRequired();

            modelBuilder.Entity<Automotora>().Property(s => s.Nombre).IsRequired();
            modelBuilder.Entity<Automotora>().Property(s => s.Fecha)
                .HasDefaultValue(DateTime.Now)
                .IsRequired();
            modelBuilder.Entity<Automotora>().Property(s => s.Telefono).IsRequired();
        }
    }
}

