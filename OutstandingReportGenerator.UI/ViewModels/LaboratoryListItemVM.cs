using OutstandingReportGenerator.UI.Models;
using OutstandingReportGenerator.UI.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingReportGenerator.UI.ViewModels
{
    public class LaboratoryListItemVM : ViewModelBase
    {
        public string LabName { get; set; }
        public ObservableCollection<OutstandingDetailsModel> Items { get; }

        public LaboratoryListItemVM(string laboratory, ObservableCollection<OutstandingDetailsModel> items)
        {
            LabName = laboratory;
            Items = items;
        }

    }
}
