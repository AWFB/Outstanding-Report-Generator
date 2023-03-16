using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingReportGenerator.UI.ViewModels;

public class OutstandingTestsTableViewModel : ViewModelBase
{
    private readonly ObservableCollection<OutstandingItemVM> _outstandingItemVM;

    public IEnumerable<OutstandingItemVM> OutstandingItemsVM => _outstandingItemVM;

    public OutstandingTestsTableViewModel()
    {
        _outstandingItemVM = new ObservableCollection<OutstandingItemVM>();

        _outstandingItemVM.Add(new OutstandingItemVM(
            "PRU", "AH123456", "Will Riker", "01/12/1985", "555 555 1234", "Albumin"));
        _outstandingItemVM.Add(new OutstandingItemVM(
            "RLUH", "AH123457", "Geordi La Forge", "18/05/1985", "555 555 4567", "Calcium"));
        _outstandingItemVM.Add(new OutstandingItemVM(
            "CMFT", "AH123458", "Jean-Luc Picard", "02/06/1985", "555 555 8901", "AST"));
    }
}
