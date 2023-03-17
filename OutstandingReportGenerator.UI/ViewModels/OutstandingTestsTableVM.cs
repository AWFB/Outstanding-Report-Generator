using OutstandingReportGenerator.UI.Models;
using OutstandingReportGenerator.UI.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingReportGenerator.UI.ViewModels;

public class OutstandingTestsTableVM : ViewModelBase
{
    private readonly ObservableCollection<OutstandingItemVM> _outstandingItemsVM;
    private readonly AppStore _appStore;

    // Binding for table data
    public IEnumerable<OutstandingItemVM> OutstandingItems => _outstandingItemsVM;

    public OutstandingTestsTableVM(AppStore appStore)
    {

    _outstandingItemsVM = new ObservableCollection<OutstandingItemVM>();
    _appStore = appStore;
      _appStore.SelectedLaboratoryChanged += _appStore_SelectedLaboratoryChanged;
    _appStore_SelectedLaboratoryChanged();
    }

  protected override void Dispose()
  {
    _appStore.SelectedLaboratoryChanged -= _appStore_SelectedLaboratoryChanged;
    base.Dispose();
  }


  private void _appStore_SelectedLaboratoryChanged()
  {
    _outstandingItemsVM.Clear();
    foreach (var item in _appStore.SelectedLaboratory.Items)
    {
      _outstandingItemsVM.Add(new OutstandingItemVM(item));
    }
  }
}
