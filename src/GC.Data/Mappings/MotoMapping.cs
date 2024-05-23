using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GC.Business.Models;

namespace GC.Data.Mappings
{
    public class MotoMapping : IEntityTypeConfiguration<Moto>
    {
        public void Configure(EntityTypeBuilder<Moto> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Modelo)
                    .IsRequired()
                   .HasColumnType("varchar(100)");

            builder.Property(m => m.Marca)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

            builder.Property(m => m.Placa)
                    .IsRequired()
                    .HasColumnType("varchar(7)");

            builder.ToTable("Motos");

        }
    }
}
