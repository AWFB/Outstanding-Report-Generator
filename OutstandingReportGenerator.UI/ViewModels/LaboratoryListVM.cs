using OutstandingReportGenerator.UI.Commands;
using OutstandingReportGenerator.UI.Models;
using OutstandingReportGenerator.UI.Stores;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace OutstandingReportGenerator.UI.ViewModels
{
    public class LaboratoryListVM : ViewModelBase
    {
        private readonly DataStore _dataStore;
        private readonly SelectedLabStore _selectedLabStore;
        private ObservableCollection<OutstandingDetailsModel> _labNames;
        private OutstandingDetailsModel _selectedLabName;

        public ObservableCollection<OutstandingDetailsModel> LabNames => _labNames;
        public OutstandingDetailsModel SelectedLabName
        {
            get => _selectedLabName;
            set
            {
                _selectedLabName = value;
                OnPropertyChanged(nameof(SelectedLabName));

                _selectedLabStore.SelectedLab = value;
            }
        }

        public LaboratoryListVM(DataStore dataStore, SelectedLabStore selectedLabStore)
        {
            _dataStore = dataStore;
            _selectedLabStore = selectedLabStore;
            _labNames = new ObservableCollection<OutstandingDetailsModel>();
            _selectedLabName = selectedLabStore.SelectedLab;

        }

        internal void UpdateListOfLabs()
        {
            var labNames = _dataStore.Outstanding
                     .GroupBy(o => o.LabName)
                     .Select(g => g.First())
                     .OrderBy(o => o.LabName);

            foreach (var item in labNames)
            {
                _labNames.Add(item);

            }
        }


    }
}


