using Locatora.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Locatora.Repository.Mapping
{
    public class CarroMap : IEntityTypeConfiguration<Carro>
    {
        public void Configure(EntityTypeBuilder<Carro> builder)
        {
            builder.ToTable("Carro");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Modelo)
                .IsRequired()
                .HasColumnType("varchar(25)");

            builder.Property(prop => prop.Placa)
                .IsRequired()
                .HasColumnType("varchar(8)");

            builder.Property(prop => prop.Ano)
                .IsRequired()
                .HasColumnType("int(4)");

            builder.Property(prop => prop.Valor_dia)
                .IsRequired()
                .HasColumnType("float");

            builder.Property(prop => prop.Seguro);

            builder.Property(prop => prop.Alugado);

            builder.HasOne(prop => prop.Usuario);

            builder.HasOne(prop => prop.Cidade);

            builder.HasOne(prop => prop.Estado);
        }
    }
}
