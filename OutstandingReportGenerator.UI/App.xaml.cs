using OutstandingReportGenerator.UI.Stores;
using OutstandingReportGenerator.UI.ViewModels;
using System.Windows;

namespace OutstandingReportGenerator.UI
{
    public partial class App : Application
    {

        private readonly SelectedLabStore _selectedLabStore;

        public App()
        {
            _selectedLabStore = new SelectedLabStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new OutstandingTestsVM(_selectedLabStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
