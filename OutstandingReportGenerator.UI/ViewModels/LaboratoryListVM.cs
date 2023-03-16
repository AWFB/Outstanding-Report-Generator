using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingReportGenerator.UI.ViewModels
{
    public class LaboratoryListViewModel : ViewModelBase
    {
        // Observable collection used as UI is auto updated on delete or adding
        private readonly ObservableCollection<LaboratoryListItemViewModel> _laboratoryListItemViewModels;

        public IEnumerable<LaboratoryListItemViewModel> LaboratoryListItemViewModels => _laboratoryListItemViewModels;

        public LaboratoryListViewModel()
        {
            _laboratoryListItemViewModels = new ObservableCollection<LaboratoryListItemViewModel>();

            _laboratoryListItemViewModels.Add(new LaboratoryListItemViewModel("Barts"));
            _laboratoryListItemViewModels.Add(new LaboratoryListItemViewModel("PRU"));
            _laboratoryListItemViewModels.Add(new LaboratoryListItemViewModel("RLUH"));
        }

        
    }
}
