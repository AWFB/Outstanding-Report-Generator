﻿using Microsoft.Win32;
using OutstandingReportGenerator.UI.Models;
using OutstandingReportGenerator.UI.Stores;
using OutstandingReportGenerator.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingReportGenerator.UI.Commands
{
    public class ImportOutstandingCommand : CommandBase
    {
        private readonly DataStore _dataStore;
        private readonly LaboratoryListVM _viewModel;


        public ImportOutstandingCommand(DataStore dataStore, LaboratoryListVM viewModel)
        {
            _dataStore = dataStore;
            _viewModel = viewModel;
        }

        public override void Execute(object? parameter)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.DefaultExt = ".csv";
            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                string path = dialog.FileName;
                _dataStore.Load(path);
            }

            _viewModel.UpdateListOfLabs(_dataStore.Outstanding);
        }
    }
}
