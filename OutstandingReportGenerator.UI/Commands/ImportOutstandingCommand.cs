using Microsoft.Win32;
using OutstandingReportGenerator.UI.Models;
using OutstandingReportGenerator.UI.Stores;
using OutstandingReportGenerator.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OutstandingReportGenerator.UI.Commands
{
    public class ImportOutstandingCommand : CommandBase
    {
        private readonly DataStore _dataStore;
        private readonly LaboratoryListVM _viewModel;
        private readonly OutstandingTestsTableVM _tableViewModel;

        public ImportOutstandingCommand(DataStore dataStore, LaboratoryListVM viewModel, OutstandingTestsTableVM tableViewModel)
        {
            _dataStore = dataStore;
            _viewModel = viewModel;
            _tableViewModel = tableViewModel;
        }

        public override void Execute(object? parameter)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.DefaultExt = ".csv";
            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                _dataStore.Outstanding.Clear();
                _viewModel.LabNames.Clear();

                string path = dialog.FileName;
                try
                {
                    _dataStore.Load(path);
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to import CVS Data.", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            _viewModel.UpdateListOfLabs();
            _tableViewModel.FilterOutstandingByLabName();
        }
    }
}
