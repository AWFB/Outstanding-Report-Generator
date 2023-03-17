using OutstandingReportGenerator.UI.Models;
using OutstandingReportGenerator.UI.Stores;

namespace OutstandingReportGenerator.UI.ViewModels
{
    public class OutstandingItemVM : ViewModelBase
    {
        private readonly Item _item;

        public string AHNumber => _item.AHNumber;
        public string PatientName => _item.PatientName;
        public string DateOfBirth => _item.DateOfBirth;
        public string NHSNumber => _item.NHSNumber;
        public string TestName => _item.TestName;

        public OutstandingItemVM(Item item)
        {
            _item = item;
        }

        private void SelectedLabStore_SelectedLaboratoryChanged()
        {
            OnPropertyChanged(nameof(AHNumber));
            OnPropertyChanged(nameof(PatientName));
            OnPropertyChanged(nameof(DateOfBirth));
            OnPropertyChanged(nameof(NHSNumber));
            OnPropertyChanged(nameof(TestName));
        }
    }
}
