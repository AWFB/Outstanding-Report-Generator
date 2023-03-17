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
    private readonly AppStore _appStore;

    public IEnumerable<LaboratoryListItemViewModel> LaboratoryListItemViewModels => _laboratoryListItemViewModels;

    //SelectedLaboratoryListingItemVM

    private LaboratoryListItemViewModel? _selectedLaboratoryListingItemVM;
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

        _appStore.SelectedLaboratory = _selectedLaboratoryListingItemVM.Labratory;
      }
    }


    public LaboratoryListViewModel(AppStore appStore)
    {
      _appStore = appStore;

      _laboratoryListItemViewModels = new ObservableCollection<LaboratoryListItemViewModel>();

      foreach (var lab in _appStore.Labratories)
      {
        _laboratoryListItemViewModels.Add(new LaboratoryListItemViewModel(lab));
      }

    }
  }
}
