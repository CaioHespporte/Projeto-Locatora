using Locatora.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class ReservaMap : IEntityTypeConfiguration<Reserva>
    {
        public void Configure(EntityTypeBuilder<Reserva> builder)
        {
            builder.ToTable("Reserva");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Data_Inicio)
                .IsRequired();

            builder.Property(prop => prop.Data_Fim)
                .IsRequired();

            builder.Property(prop => prop.Valor_total)
                .IsRequired();

            builder.HasOne(prop => prop.Usuario);
            builder.HasOne(prop => prop.Cadastrar_carro);
        }
    }
}
