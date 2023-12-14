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
        public DbSet<Carro>? Carro { get; set; }
        public DbSet<Reserva>? Reserva { get; set; }
        public DbSet<Cidade>? Cidade { get; set; }
        public DbSet<Estado>? Estado { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
            modelBuilder.Entity<Carro>(new CarroMap().Configure);
            modelBuilder.Entity<Reserva>(new ReservaMap().Configure);
            modelBuilder.Entity<Cidade>(new CidadeMap().Configure);
            modelBuilder.Entity<Estado>(new EstadoMap().Configure);
        }
    }
}
