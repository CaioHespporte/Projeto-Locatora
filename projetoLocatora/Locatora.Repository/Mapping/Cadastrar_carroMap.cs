using Locatora.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Locatora.Repository.Mapping
{
    public class Cadastrar_carroMap : IEntityTypeConfiguration<Cadastrar_carro>
    {
        public void Configure(EntityTypeBuilder<Cadastrar_carro> builder)
        {
            builder.ToTable("Cadastrar_carro");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Modelo)
                .IsRequired()
                .HasColumnType("varchar(25)");

            builder.Property(prop => prop.Placa)
                .IsRequired()
                .HasColumnType("varchar(8)");

            builder.Property(prop => prop.Cidade)
                .IsRequired()
                .HasColumnType("varchar(30)");

            builder.Property(prop => prop.Estado)
                .IsRequired()
                .HasColumnType("varchar(2)");

            builder.Property(prop => prop.Ano)
                .IsRequired()
                .HasColumnType("int(4)");

            builder.Property(prop => prop.Valor_dia)
                .IsRequired()
                .HasColumnType("float");

            builder.Property(prop => prop.Seguro);

            builder.HasOne(prop => prop.Usuario);
        }
    }
}
