using OutstandingReportGenerator.UI.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OutstandingReportGenerator.Data;
using System.Windows.Input;
using OutstandingReportGenerator.UI.Commands;

namespace OutstandingReportGenerator.UI.Models
{
    public class OutstandingDetailsModel
    { 
        public OutstandingDetailsModel(CSVInputModel inputModel) {
            LabName = inputModel.RefLabName;
            AHNumber = inputModel.UnitNumber;
            PatientName = inputModel.PatientName;
            DateOfBirth = inputModel.DateOfBirth;
            NHSNumber = inputModel.NHSNumber;
            TestName = inputModel.TestRequested;
        }

        public string LabName { get; }
        public string AHNumber { get; }
        public string PatientName { get; }
        public string DateOfBirth { get; }
        public string NHSNumber { get; }
        public string TestName { get; }
    }
}
