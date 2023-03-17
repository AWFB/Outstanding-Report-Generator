using OutstandingReportGenerator.UI.Stores;

namespace OutstandingReportGenerator.UI.ViewModels
{
    public class OutstandingItemVM : ViewModelBase
    {
        private readonly SelectedLabStore _selectedLabStore;

        public string LabName => _selectedLabStore.SelectedLaboratory.LabName;
        public string AHNumber => _selectedLabStore.SelectedLaboratory.AHNumber;
        public string PatientName => _selectedLabStore.SelectedLaboratory.PatientName;
        public string DateOfBirth => _selectedLabStore.SelectedLaboratory.DateOfBirth;
        public string NHSNumber => _selectedLabStore.SelectedLaboratory.NHSNumber;
        public string TestName => _selectedLabStore.SelectedLaboratory.TestName;

        public OutstandingItemVM(SelectedLabStore selectedLabStore)
        {
            _selectedLabStore = selectedLabStore;

            _selectedLabStore.SelectedLaboratoryChanged += SelectedLabStore_SelectedLaboratoryChanged;
        }

        protected override void Dispose()
        {
            _selectedLabStore.SelectedLaboratoryChanged -= SelectedLabStore_SelectedLaboratoryChanged;
            base.Dispose();
        }

        private void SelectedLabStore_SelectedLaboratoryChanged()
        {
            OnPropertyChanged(nameof(LabName));
            OnPropertyChanged(nameof(AHNumber));
            OnPropertyChanged(nameof(PatientName));
            OnPropertyChanged(nameof(DateOfBirth));
            OnPropertyChanged(nameof(NHSNumber));
            OnPropertyChanged(nameof(TestName));
        }
    }
}
