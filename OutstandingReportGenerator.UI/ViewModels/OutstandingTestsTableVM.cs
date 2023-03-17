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
    private readonly ObservableCollection<OutstandingItemVM> _outstandingItemVM;
    private readonly SelectedLabStore _selectedLabStore;

    // Binding for table data
    public IEnumerable<OutstandingItemVM> Outstanding => _outstandingItemVM;

    public OutstandingTestsTableVM(SelectedLabStore selectedLabStore)
    {
        _outstandingItemVM = new ObservableCollection<OutstandingItemVM>();
        _selectedLabStore = selectedLabStore;

        _outstandingItemVM.Add(new OutstandingItemVM(_selectedLabStore));
        
    }
}
