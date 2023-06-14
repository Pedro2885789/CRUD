using System.Configuration;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CRUD.Infra;
using CRUD.Dominio;
using CRUD.Infra.Repositorio;

namespace CRUD
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var builder = CriaHostBuilder();
            var serviceProvider = builder.Build().Services;
            var scope = serviceProvider.CreateScope();
            UpdateDatabase(scope.ServiceProvider);
            var repositorio = serviceProvider.GetService<IRepositorio>()
                ?? throw new Exception("Servi�o reposit�rio n�o encontrado");

            ApplicationConfiguration.Initialize();
            Application.Run(new ControleDePecas(repositorio));
        }

        private static void UpdateDatabase(IServiceProvider serviceProvider)
        {
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
            runner.MigrateUp();
        }

        static IHostBuilder CriaHostBuilder()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;

            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddScoped<IRepositorio, RepositorioSql>();
                    services.AddFluentMigratorCore()
                        .ConfigureRunner(rb => rb
                                .AddSqlServer()
                                .WithGlobalConnectionString(connectionString)
                                .ScanIn(typeof(AdicionaTabelaPeca).Assembly).For.Migrations())
                            .AddLogging(lb => lb.AddFluentMigratorConsole())
                            .BuildServiceProvider(false);
                });
        }
    }
}