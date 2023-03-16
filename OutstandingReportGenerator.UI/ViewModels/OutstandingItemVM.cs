using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingReportGenerator.UI.ViewModels
{
    public class OutstandingItemVM : ViewModelBase
    {
        public OutstandingItemVM(string labName, string aHNumber, string patientName, string dateOfBirth, string nHSNumber, string testName)
        {
            LabName = labName;
            AHNumber = aHNumber;
            PatientName = patientName;
            DateOfBirth = dateOfBirth;
            NHSNumber = nHSNumber;
            TestName = testName;
        }

        public string LabName { get; }
        public string AHNumber { get; }
        public string PatientName { get; }
        public string DateOfBirth { get; }
        public string NHSNumber { get; }
        public string TestName { get; }
    }
}
