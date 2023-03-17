using OutstandingReportGenerator.UI.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingReportGenerator.UI.Models
{
    public class Item
    {

        public Item(string aHNumber, string patientName, string dateOfBirth, string nhsNumber, string testName)
        {
            AHNumber = aHNumber;
            PatientName = patientName;
            DateOfBirth = dateOfBirth;
            NHSNumber = nhsNumber;
            TestName = testName;
        }
        public string AHNumber { get; }
        public string PatientName { get; }
        public string DateOfBirth { get; }
        public string NHSNumber { get; }
        public string TestName { get; }
    }
}
