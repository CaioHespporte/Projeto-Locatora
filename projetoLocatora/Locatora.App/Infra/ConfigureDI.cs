using AutoMapper;
using Locatora.App.Cadastros;
using Locatora.App.Listas;
using Locatora.App.Models;
using Locatora.App.Outros;
using Locatora.Domain.Base;
using Locatora.Domain.Entities;
using Locatora.Repository.Context;
using Locatora.Repository.Mapping;
using Locatora.Repository.Repository;
using Locatora.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;


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
            Services.AddScoped<IBaseRepository<Carro>, BaseRepository<Carro>>();
            Services.AddScoped<IBaseRepository<Reserva>, BaseRepository<Reserva>>();
            Services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            Services.AddScoped<IBaseRepository<Estado>, BaseRepository<Estado>>();

            // Services
            Services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            Services.AddScoped<IBaseService<Carro>, BaseService<Carro>>();
            Services.AddScoped<IBaseService<Reserva>, BaseService<Reserva>>();
            Services.AddScoped<IBaseService<Estado>, BaseService<Estado>>();
            Services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();

            // Formulários
            Services.AddTransient<Login, Login>();
            Services.AddTransient<CadastroUsuario, CadastroUsuario>();
            Services.AddTransient<CadastroCarro, CadastroCarro>();
            Services.AddTransient<ListaExibirReservas, ListaExibirReservas>();
            Services.AddTransient<ListaProcurarCarro, ListaProcurarCarro>();
            Services.AddTransient<ListaMeusCarros, ListaMeusCarros>();
            Services.AddTransient<ConfirmarReserva, ConfirmarReserva>();
            Services.AddTransient<FormPrincipal, FormPrincipal>();


            // Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Usuario, UsuarioModel>();

                config.CreateMap<Reserva, ReservaModel>()
                    .ForMember(d => d.IdUsuario, d => d.MapFrom(x => x.Usuario!.Id))
                    .ForMember(d => d.Usuario, d => d.MapFrom(x => x.Usuario!.Nome))
                    .ForMember(d => d.IdCarro, d => d.MapFrom(x => x.Carro!.Id))
                    .ForMember(d => d.Carro, d => d.MapFrom(x => x.Carro!.Modelo));

                config.CreateMap<Carro, CarroModel>()
                    .ForMember(d => d.IdUsuario, d => d.MapFrom(x => x.Usuario!.Id))
                    .ForMember(d => d.Usuario, d => d.MapFrom(x => x.Usuario!.Nome))
                    .ForMember(d => d.idCidade, d => d.MapFrom(x => x.Cidade!.Id))
                    .ForMember(d => d.Cidade, d => d.MapFrom(x => x.Cidade!.Nome))
                    .ForMember(d => d.idEstado, d => d.MapFrom(x => x.Estado!.Id))
                    .ForMember(d => d.Estado, d => d.MapFrom(x => x.Estado!.Nome));

                config.CreateMap<Cidade, CidadeModel>()
                    .ForMember(d => d.IdEstado, d => d.MapFrom(x => x.Estado!.Id))
                    .ForMember(d => d.Estado, d => d.MapFrom(x => x.Estado!.Nome));


            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}
