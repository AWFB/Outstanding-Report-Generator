using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OutstandingReportGenerator.Data.Data;
using OutstandingReportGenerator.Data.Databases;
using OutstandingReportGenerator.UI.ViewModels;
using System.IO;
using System.Windows;

namespace OutstandingReportGenerator.UI
{
    public partial class App : Application
    {
        public static IHost? AppHost { get; private set; }

        public App()
        {
            var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");

            IConfiguration config = builder.Build();

            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {

                    services.AddSingleton(config);
                    services.AddSingleton<MainWindow>();
                    services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
                    services.AddSingleton<ISqlData, SqlData>();
                })
                .Build();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost!.StartAsync();

            var startupForm = AppHost.Services.GetRequiredService<MainWindow>();
            startupForm.DataContext = new OutstandingTestsVM();
            startupForm.Show();



            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost!.StopAsync();

            base.OnExit(e);
        }
    }
}
