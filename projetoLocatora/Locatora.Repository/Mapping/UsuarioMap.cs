using Locatora.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Locatora.Repository.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .HasConversion(prop => prop!.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Email)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Senha)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Telefone)
                .IsRequired()
                .HasColumnType("varchar(11)");

            builder.Property(prop => prop.Rg)
                .IsRequired()
                .HasColumnType("int(9)");

            builder.Property(prop => prop.CPF)
                .IsRequired()
                .HasColumnType("varchar(11)");

            builder.Property(prop => prop.DataCadastro)
                .HasDefaultValue(DateTime.Now);

            builder.Property(prop => prop.DataNascimento)
                .IsRequired();
        }

    }
}
