using Aanwezigheidslijst.EF.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace Aanwezigheidslijst.EF
{
    public class AanwezigheidslijstDbContext : DbContext
    {
        public DbSet<Docent> Docenten { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source =aanwezigheidslijst.db");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Docent>()
                .Property(d => d.Naam).IsRequired();

            modelBuilder.Entity<Docent>()
                .ToTable("Docenten")
                .HasKey(d => d.Id);
            base.OnModelCreating(modelBuilder);
        }
    }
}
