using AutoMapper;
using Locatora.App.Cadastros;
using Locatora.App.Listas;
using Locatora.App.Models;
using Locatora.App.Outros;
using Locatora.Domain.Base;
using Locatora.Domain.Entities;
using Locatora.Repository.Context;
using Locatora.Repository.Repository;
using Locatora.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace Locatora.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;

        public static ServiceProvider? ServicesProvider;

        public static void ConfiguraServices()
        {
            Services = new ServiceCollection();
            Services.AddDbContext<MySqlContext>(options =>
            {
                var strCon = File.ReadAllText("Config/DatabaseSettings.txt");
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.EnableSensitiveDataLogging();


                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);

                });
            });

            // Repositories
            Services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            Services.AddScoped<IBaseRepository<Cadastrar_carro>, BaseRepository<Cadastrar_carro>>();
            Services.AddScoped<IBaseRepository<Reserva>, BaseRepository<Reserva>>();
            Services.AddScoped<IBaseRepository<Ofertas_reserva>, BaseRepository<Ofertas_reserva>>();

            // Services
            Services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            Services.AddScoped<IBaseService<Cadastrar_carro>, BaseService<Cadastrar_carro>>();
            Services.AddScoped<IBaseService<Reserva>, BaseService<Reserva>>();
            Services.AddScoped<IBaseService<Ofertas_reserva>, BaseService<Ofertas_reserva>>();

            // Formulários
            Services.AddTransient<Login, Login>();
            Services.AddTransient<CadastroUsuario, CadastroUsuario>();
            Services.AddTransient<CadastroCarro, CadastroCarro>();
            Services.AddTransient<ListaExibirReservas, ListaExibirReservas>();
            Services.AddTransient<ListaProcurarCarro, ListaProcurarCarro>();
            Services.AddTransient<ConfirmarReserva, ConfirmarReserva>();
            Services.AddTransient<FormPrincipal, FormPrincipal>();

            // Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Usuario, UsuarioModel>();

                config.CreateMap<Reserva, ReservaModel>()
                    .ForMember(d => d.IdUsuario, d => d.MapFrom(x => x.Usuario!.Id))
                    .ForMember(d => d.Usuario, d => d.MapFrom(x => x.Usuario!.Nome))
                    .ForMember(d => d.IdCadastrar_Carro, d => d.MapFrom(x => x.Cadastrar_carro!.Id))
                    .ForMember(d => d.Cadastrar_carro, d => d.MapFrom(x => x.Cadastrar_carro!.Modelo));

                config.CreateMap<Cadastrar_carro, Cadastrar_carroModel>()
                    .ForMember(d => d.IdUsuario, d => d.MapFrom(x => x.Usuario!.Id))
                    .ForMember(d => d.Usuario, d => d.MapFrom(x => x.Usuario!.Nome));

                config.CreateMap<Oferta, OfertaModel>()
                    .ForMember(d => d.IdUsuario, d => d.MapFrom(x => x.Usuario!.Id))
                    .ForMember(d => d.Usuario, d => d.MapFrom(x => x.Usuario!.Nome));

                config.CreateMap<Ofertas_reserva, Ofertas_reservaModel>()
                    .ForMember(d => d.IdUsuario,d => d.MapFrom(x => x.Usuario!.Id))
                    .ForMember(d => d.Usuario, d => d.MapFrom(x => x.Usuario!.Nome))
                    .ForMember(d => d.IdCadastrar_Carro,d => d.MapFrom(x => x.Cadastrar_carro!.Id))
                    .ForMember(d => d.Cadastrar_carro, d => d.MapFrom(x => x.Cadastrar_carro!.Modelo));

            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}
