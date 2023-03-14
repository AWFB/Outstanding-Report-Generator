using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingReportGenerator.UI.ViewModels;

public class OutstandingTestsTableViewModel : ViewModelBase
{
    public string LabName { get; }
    public string AHNumber { get; }
    public string PatientName { get; }
    public string DateOfBirth { get; }
    public string NHSNumber { get; }
    public string TestName { get; }

    public OutstandingTestsTableViewModel()
    {
        LabName = "PRU";
        AHNumber = "1234567890";
        PatientName = "William Riker";
        DateOfBirth = "01/01/1985";
        NHSNumber = "555 555 1234";
        TestName = "Albumin";
    }
}
