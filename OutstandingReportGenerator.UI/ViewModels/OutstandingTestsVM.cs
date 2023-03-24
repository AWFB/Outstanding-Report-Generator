using OutstandingReportGenerator.UI.Commands;
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
    public OutstandingTestsTableVM OutstandingTestsTableVM { get; }
    public LaboratoryListVM LaboratoryListVM { get; }

    public ICommand SubmitCommand { get; }

    public OutstandingTestsVM(DataStore dataStore)
    {
        
        OutstandingTestsTableVM = new OutstandingTestsTableVM(dataStore);
        LaboratoryListVM = new LaboratoryListVM(dataStore);
        SubmitCommand = new ImportOutstandingCommand(dataStore, LaboratoryListVM);
    }
}
