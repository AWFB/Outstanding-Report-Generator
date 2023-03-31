using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OutstandingReportGenerator.Data;
using OutstandingReportGenerator.UI.Stores;
using OutstandingReportGenerator.UI.ViewModels;
using System.Collections.Generic;
using System.Windows;

namespace OutstandingReportGenerator.UI
{
    public partial class App : Application
    {
        private readonly IHost _host;

        public App()
        {
            _host = Host.CreateDefaultBuilder().ConfigureServices(services =>
            {
                services.AddSingleton<DataStore>();
                services.AddSingleton<SelectedLabStore>();

                services.AddSingleton<OutstandingTestsVM>();
                services.AddSingleton(s => new MainWindow()
                {
                    DataContext = s.GetRequiredService<OutstandingTestsVM>()
                });
            })
            .Build();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _host.Start();

            MainWindow = _host.Services.GetRequiredService<MainWindow>();
            MainWindow.Show();

            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            _host.Dispose();
            base.OnExit(e);
        }
    }
}
