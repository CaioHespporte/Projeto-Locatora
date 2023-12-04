using Locatora.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Locatora.Repository.Mapping
{
    public class OfertaMap : IEntityTypeConfiguration<Oferta>
    {
        public void Configure(EntityTypeBuilder<Oferta> builder)
        {
            builder.ToTable("Oferta");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Data)
                .IsRequired();

            builder.Property(prop => prop.ValorTotal)
                .IsRequired();

            builder.HasOne(prop => prop.Usuario);

            builder.HasMany(prop => prop.Ofertas);

        }
    }

    public class Ofertas_reservaMap : IEntityTypeConfiguration<Ofertas_reserva>
    {
        public void Configure(EntityTypeBuilder<Ofertas_reserva> builder)
        {
            builder.ToTable("Ofertas_reserva");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Preco)
                .IsRequired();


            builder.HasOne(prop => prop.Usuario);
            builder.HasOne(prop => prop.Cadastrar_carro);
            builder.HasOne(prop => prop.Oferta);

        }
    }
}
