using OutstandingReportGenerator.UI.Models;
using OutstandingReportGenerator.UI.Stores;
using System.Collections.ObjectModel;
using System.Linq;

namespace OutstandingReportGenerator.UI.ViewModels
{
    public class LaboratoryListVM : ViewModelBase
    {
        private readonly DataStore _dataStore;
        private readonly SelectedLabStore _selectedLabStore;
        private ObservableCollection<OutstandingDetailsModel> _labNames;

        public ObservableCollection<OutstandingDetailsModel> LabNames => _labNames;

        private OutstandingDetailsModel _selectedLabName;
        public OutstandingDetailsModel SelectedLabName
        {
            get
            {
                return _selectedLabName;
            }
            set
            {
                _selectedLabName = value;
                OnPropertyChanged(nameof(SelectedLabName));

                _selectedLabStore.SelectedLabName = value;
            }
        }

        public LaboratoryListVM(DataStore dataStore, SelectedLabStore selectedLabStore)
        {
            _dataStore = dataStore;
            _selectedLabStore = selectedLabStore;
            _labNames = new ObservableCollection<OutstandingDetailsModel>();
            _selectedLabName = selectedLabStore.SelectedLabName;
        }

        internal void UpdateListOfLabs()
        {
            var filtered = _dataStore.Outstanding
                     .GroupBy(o => o.LabName)
                     .Select(g => g.First())
                     .OrderBy(o => o.LabName);

            foreach (var item in filtered)
            {
                _labNames.Add(item);
            }
        }


    }
}


