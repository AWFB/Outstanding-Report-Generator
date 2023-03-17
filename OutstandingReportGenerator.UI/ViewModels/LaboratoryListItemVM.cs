using OutstandingReportGenerator.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingReportGenerator.UI.ViewModels;

public class LaboratoryListItemViewModel : ViewModelBase
{
    public OutstandingDetailsModel OutstandingDetailsModel { get; }

    public string LabName => OutstandingDetailsModel.LabName;
    public int NumberOfOutstandingTests { get; set; }

    public LaboratoryListItemViewModel(OutstandingDetailsModel outstandingDetailsModel)
    {
        OutstandingDetailsModel = outstandingDetailsModel;
    }
}
