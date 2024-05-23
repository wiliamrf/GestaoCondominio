using GC.Business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC.Data.Context
{
    public class GCDbContext : DbContext
    {
        public GCDbContext(DbContextOptions options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public DbSet<Apartamento> Apartamentos { get; set;}
        public DbSet<Carro> Carros { get; set;}
        public DbSet<Moto> Motos { get; set;}
        public DbSet<Correspondecia> Correspondeciaes { get; set;}

        //# Holding
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Carro>()
        //        .HasOne(c => c.Apartamento) // Especifica a propriedade de navegação
        //        .WithOne(a => a.Carro); // Indica que Carro pode esta associado a Um apartamento

        //    modelBuilder.Entity<Moto>()
        //       .HasOne(m => m.Apartamento) // Especifica a propriedade de navegação
        //       .WithOne(a => a.Moto); // Indica que Moto pode esta associado a Um apartamento

        //}
    }
}
