using OutstandingReportGenerator.UI.Models;
using OutstandingReportGenerator.UI.Stores;
using System.Collections.ObjectModel;
using System.Linq;

namespace OutstandingReportGenerator.UI.ViewModels
{
    public class LaboratoryListVM : ViewModelBase
    {
        private readonly DataStore _dataStore;

        private ObservableCollection<OutstandingDetailsModel> _labNames;

        public ObservableCollection<OutstandingDetailsModel> Outstanding => _dataStore.Outstanding;

        public ObservableCollection<OutstandingDetailsModel> LabNames => _labNames;
        //{
        //    get { return _labNames; }
        //    set
        //    {
        //        if (_labNames != value)
        //        {
        //            _labNames = value;
        //            OnPropertyChanged(nameof(LabNames));
        //        }
        //    }
        //}

        // prop for selected item 


        public LaboratoryListVM(DataStore dataStore)
        {
            _dataStore = dataStore;
            _labNames = new ObservableCollection<OutstandingDetailsModel>();
        }

        internal void UpdateListOfLabs(ObservableCollection<OutstandingDetailsModel> outstanding)
        {
            var filtered = outstanding
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


