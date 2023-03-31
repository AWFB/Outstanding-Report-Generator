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

    public ICommand ImportOutstandingCommand { get; }
    public ICommand GenerateEmailCommand { get; }

    public OutstandingTestsVM(DataStore dataStore, SelectedLabStore selectedLabStore)
    {
        
        OutstandingTestsTableVM = new OutstandingTestsTableVM(dataStore, selectedLabStore);
        LaboratoryListVM = new LaboratoryListVM(dataStore, selectedLabStore);
        ImportOutstandingCommand = new ImportOutstandingCommand(dataStore, LaboratoryListVM, OutstandingTestsTableVM);
        GenerateEmailCommand = new GenerateEmailCommand(OutstandingTestsTableVM, selectedLabStore);
    }
}
