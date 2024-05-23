using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GC.Business.Models;

namespace GC.Data.Mappings
{
    public class CarroMapping : IEntityTypeConfiguration<Carro>
    {
        public void Configure(EntityTypeBuilder<Carro> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Modelo)
                    .IsRequired()
                   .HasColumnType("varchar(100)");

            builder.Property(c => c.Marca)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

            builder.Property(c => c.Placa)
                    .IsRequired()
                    .HasColumnType("varchar(7)");

            builder.ToTable("Carros");

        }
    }
}
