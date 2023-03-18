using OutstandingReportGenerator.UI.Models;
using OutstandingReportGenerator.UI.Stores;
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
        private readonly SelectedLabStore _selectedLabStore;

        public IEnumerable<LaboratoryListItemViewModel> LaboratoryListItemViewModels => _laboratoryListItemViewModels;

        //SelectedLaboratoryListingItemVM

        private LaboratoryListItemViewModel _selectedLaboratoryListingItemVM;
        public LaboratoryListItemViewModel SelectedLaboratoryListingItemVM
        {
            get
            {
                return _selectedLaboratoryListingItemVM;
            }
            set
            {
                _selectedLaboratoryListingItemVM = value;
                OnPropertyChanged(nameof(SelectedLaboratoryListingItemVM));

                _selectedLabStore.SelectedLaboratory = _selectedLaboratoryListingItemVM.OutstandingDetailsModel;
            }
        }


        public LaboratoryListViewModel(SelectedLabStore selectedLabStore)
        {
            _selectedLabStore = selectedLabStore;
            _laboratoryListItemViewModels = new ObservableCollection<LaboratoryListItemViewModel>
            {
                new LaboratoryListItemViewModel(new OutstandingDetailsModel
                ("PRU", "AH123456", "Dave Lister", "01/12/1987", "555 555 1234", "Calcium")),

                new LaboratoryListItemViewModel(new OutstandingDetailsModel
                ("RLUH", "AH123456", "WIll Riker", "01/12/1987", "555 555 1234", "Albumin"))
            };


        }

        
    }
}
