using OutstandingReportGenerator.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingReportGenerator.UI.ViewModels
{
    public class OutstandingItemVM : ViewModelBase
    {
        private readonly OutstandingDetailsModel _outstandingDetailsModel;

        public string LabName => _outstandingDetailsModel.LabName;
        public string AHNumber => _outstandingDetailsModel.AHNumber;
        public string PatientName => _outstandingDetailsModel.PatientName;
        public string DateOfBirth => _outstandingDetailsModel.DateOfBirth;
        public string NHSNumber => _outstandingDetailsModel.NHSNumber;
        public string TestName => _outstandingDetailsModel.LabName;

        public OutstandingItemVM(OutstandingDetailsModel outstandingDetailsModel)
        {
            _outstandingDetailsModel = outstandingDetailsModel;
        }
    }
}
