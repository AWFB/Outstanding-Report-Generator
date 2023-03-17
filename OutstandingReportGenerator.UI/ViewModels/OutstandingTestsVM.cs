using OutstandingReportGenerator.UI.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OutstandingReportGenerator.UI.ViewModels;

public class OutstandingTestsVM : ViewModelBase
{
    public LaboratoryListViewModel LaboratoryListViewModel { get; }
    public OutstandingTestsTableVM OutstandingTestsTableViewModel { get; }

    //public ICommand ImportCsvFileCommand { get; }

    public OutstandingTestsVM(SelectedLabStore _selectedLabStore)
    {
        LaboratoryListViewModel = new LaboratoryListViewModel(_selectedLabStore);
        OutstandingTestsTableViewModel = new OutstandingTestsTableVM(_selectedLabStore);
    }
}
