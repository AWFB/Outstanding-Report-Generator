using OutstandingReportGenerator.UI.Models;
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

    // Binding for table data
    public IEnumerable<OutstandingItemVM> Outstanding => _outstandingItemVM;

    public OutstandingTestsTableVM()
    {
        _outstandingItemVM = new ObservableCollection<OutstandingItemVM>();

        _outstandingItemVM.Add(new OutstandingItemVM( new OutstandingDetailsModel(
            "PRU", "AH123456", "Will Riker", "01/12/1985", "555 555 1234", "Albumin")));
        _outstandingItemVM.Add(new OutstandingItemVM(new OutstandingDetailsModel(
            "RLUH", "AH123457", "Geordi La Forge", "18/05/1985", "555 555 4567", "Calcium")));
        _outstandingItemVM.Add(new OutstandingItemVM(new OutstandingDetailsModel(
            "CMFT", "AH123458", "Jean-Luc Picard", "02/06/1985", "555 555 8901", "AST")));
    }
}
