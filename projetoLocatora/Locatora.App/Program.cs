using Locatora.App.Infra;
using Locatora.Domain.Base;
using Locatora.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace Locatora.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureDI.ConfiguraServices();
            var usuarioService = ConfigureDI.ServicesProvider!.GetService<IBaseService<Usuario>>();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormPrincipal(usuarioService));
        }
    }
}