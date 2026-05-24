using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using HelpDeskWindowsForms.Data;
using HelpDeskWindowsForms.Service;
using HelpDeskWindowsForms.Repositories;
using System.Linq;
using HelpDeskWindowsForms.UI;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace HelpDeskWindowsForms
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; } = null!;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            // BD SQLLite
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite("Data Source=helpdesk.db"));

            // REGISTRO DAS DEPENDÊNCIAS
            services.AddScoped<UsuarioService>();
            services.AddScoped<UsuarioRepository>();

            services.AddScoped<ChamadoService>();
            services.AddScoped<ChamadoRepository>();


            // Registrar os formulários para que possam receber injeção de dependência
            services.AddTransient<Login>();
            services.AddTransient<Cadastro>();
            services.AddTransient<DetalheAnalista>();
            services.AddTransient<DashboardCliente>();
            services.AddTransient<DashboardAnalista>();
            services.AddTransient<NovoChamado>();

            ServiceProvider = services.BuildServiceProvider();

            // Lidar com o Banco de Dados (Migrations)
            using (var scope = ServiceProvider.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                // Apenas em ambiente de desenvolvimento, em produção seria melhor gerenciar por fora
                var hasPendingMigrations = db.Database.GetPendingMigrations().Any();

                if (hasPendingMigrations)
                {
                    // Alerta: Caso precise recriar o banco
                    // db.Database.EnsureDeleted(); // apaga tudo
                    db.Database.Migrate();       // recria com migrations
                }
            }

            // Iniciar a aplicação resolvendo o formulário inicial da Injeção de Dependências
            // Iniciar a aplicação resolvendo o formulário 'DetalheAnalista' através da injeção de dependência
            Application.Run(ServiceProvider.GetRequiredService<Login>());
        }
    }
}
