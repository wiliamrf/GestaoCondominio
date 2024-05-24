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

        public DbSet<Apartamento> Apartamentos { get; set; }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Moto> Motos { get; set; }
        public DbSet<Correspondecia> Correspondeciaes { get; set; }

        //# Holding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Apartamento>()
            .HasOne(a => a.Carro)
            .WithOne(c => c.Apartamento)
            .HasForeignKey<Carro>(c => c.ApartamentoId);

            modelBuilder.Entity<Carro>()
                .HasOne(c => c.Apartamento)
                .WithOne(a => a.Carro)
                .HasForeignKey<Apartamento>(a => a.Id);

            modelBuilder.Entity<Apartamento>()
            .HasOne(a => a.Moto)
            .WithOne(c => c.Apartamento)
            .HasForeignKey<Moto>(c => c.ApartamentoId);

            modelBuilder.Entity<Moto>()
                .HasOne(c => c.Apartamento)
                .WithOne(a => a.Moto)
                .HasForeignKey<Apartamento>(a => a.Id);



            modelBuilder.Entity<Correspondecia>()
               .HasOne(p => p.Apartamento) // Especifica a propriedade de navegação
               .WithMany() // Indica que o produto pode estar associado a muitos itens de pedido
               .HasForeignKey(p => p.ApartamentoId); // Define a chave estrangeira

            base.OnModelCreating(modelBuilder);
        }
    }
}
