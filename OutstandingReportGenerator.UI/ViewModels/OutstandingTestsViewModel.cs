using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OutstandingReportGenerator.UI.ViewModels;

public class OutstandingTestsViewModel : ViewModelBase
{
    public LaboratoryListViewModel LaboratoryListViewModel { get; }
    public OutstandingTestsTableViewModel OutstandingTestsTableViewModel { get; }

    public ICommand ImportCsvFileCommand { get; }

    public OutstandingTestsViewModel()
    {
        LaboratoryListViewModel = new LaboratoryListViewModel();
        OutstandingTestsTableViewModel = new OutstandingTestsTableViewModel();
    }
}
