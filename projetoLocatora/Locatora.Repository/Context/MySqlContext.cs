using IFSPStore.Repository.Mapping;
using Locatora.Domain.Entities;
using Locatora.Repository.Mapping;
using Microsoft.EntityFrameworkCore;


namespace Locatora.Repository.Context
{
    public sealed class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated();
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Usuario>? Usuario { get; set; }
        public DbSet<Oferta>? Oferta { get; set; }
        public DbSet<Ofertas_reserva>? Ofertas_reserva { get; set; }
        public DbSet<Cadastrar_carro>? Cadastrar_carro { get; set; }
        public DbSet<Reserva>? Reserva { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);            
            modelBuilder.Entity<Oferta>(new OfertaMap().Configure);
            modelBuilder.Entity<Ofertas_reserva>(new Ofertas_reservaMap().Configure);
            modelBuilder.Entity<Cadastrar_carro>(new Cadastrar_carroMap().Configure);
            modelBuilder.Entity<Reserva>(new ReservaMap().Configure);
        }
    }
}
