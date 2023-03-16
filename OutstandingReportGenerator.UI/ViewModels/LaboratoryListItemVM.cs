using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingReportGenerator.UI.ViewModels;

public class LaboratoryListItemViewModel : ViewModelBase
{
    public string LabName { get; set; }
    public int NumberOfOutstandingTests { get; set; }

    public LaboratoryListItemViewModel(string labName)
    {
        LabName = labName;
    }

}
