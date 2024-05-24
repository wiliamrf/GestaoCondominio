using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GC.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC.Data.Mappings
{
    public class ApartamentoMapping : IEntityTypeConfiguration<Apartamento>
    {
        public void Configure(EntityTypeBuilder<Apartamento> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Nome)
                    .IsRequired()
                   .HasColumnType("varchar(200)");

            builder.Property(a => a.NumeroApto)
                    .IsRequired();

            builder.Property(a => a.Telefone)
                   .IsRequired();

            builder.Property(a => a.Cpf)
                .IsRequired()
                .HasColumnType("varchar(14)");

            builder.Property(a => a.Observacao)
                   .HasColumnType("varchar(500)");

            // 1:1 =>  Carro

            builder.HasOne(a => a.Carro)
                    .WithOne(c => c.Apartamento);

            // 1:1 =>  Moto

            builder.HasOne(a => a.Moto)
                    .WithOne(m => m.Apartamento);

            //1:N => Correspondecias

            builder.HasMany(a => a.Correspondecias)
                    .WithOne(co => co.Apartamento)
                    .HasForeignKey(co => co.ApartamentoId);

            builder.ToTable("Apartamentos");

        }
    }
}
