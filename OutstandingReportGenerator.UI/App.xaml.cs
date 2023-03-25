using OutstandingReportGenerator.Data;
using OutstandingReportGenerator.UI.Stores;
using OutstandingReportGenerator.UI.ViewModels;
using System.Collections.Generic;
using System.Windows;

namespace OutstandingReportGenerator.UI
{
    public partial class App : Application
    {
        private readonly DataStore _dataStore;
        private readonly SelectedLabStore _selectedLabStore;

        public App()
        {
            _dataStore = new DataStore();
            _selectedLabStore = new SelectedLabStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new OutstandingTestsVM(_dataStore, _selectedLabStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
