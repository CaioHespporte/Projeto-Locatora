using Locatora.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Locatora.Repository.Mapping
{
    public class EstadoMap : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.ToTable("Estado");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(30)");

            builder.Property(prop => prop.Uf)
                .IsRequired()
                .HasColumnType("varchar(2)");

            //builder.HasMany(prop => prop.Cidades)
            //    .WithOne(prop => prop.Estado)
            //    .HasForeignKey(prop => prop.EstadoId);
        }
    }
}
