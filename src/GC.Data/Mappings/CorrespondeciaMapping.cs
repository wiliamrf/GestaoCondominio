using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GC.Business.Models;

namespace GC.Data.Mappings
{
    public class CorrespondeciaMapping : IEntityTypeConfiguration<Correspondecia>
    {
        public void Configure(EntityTypeBuilder<Correspondecia> builder)
        {
            builder.HasKey(co => co.Id);

            builder.Property(co => co.Descricao)
                   .IsRequired()
                   .HasColumnType("varchar(200)");


            builder.Property(co => co.Rastreio)
                   .IsRequired()
                   .HasColumnType("varchar(100)");


            builder.Property(co => co.Entrega)
                   .IsRequired();


            builder.ToTable("Correspondecias");
        }
    }
}
