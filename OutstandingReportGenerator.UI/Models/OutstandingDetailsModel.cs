using OutstandingReportGenerator.Data;

namespace OutstandingReportGenerator.UI.Models
{
    public class OutstandingDetailsModel
    {
        public OutstandingDetailsModel(CSVInputModel inputModel)
        {
            LabName = inputModel.RefLabName;
            AHNumber = inputModel.UnitNumber;
            PatientName = inputModel.PatientName;
            DateOfBirth = inputModel.DateOfBirth;
            NHSNumber = inputModel.NHSNumber;
            TestName = inputModel.TestRequested;
            Collected = inputModel.Collected;
            SpecNumber = inputModel.SpecNumber;
        }

        public string LabName { get; }
        public string AHNumber { get; }
        public string PatientName { get; }
        public string DateOfBirth { get; }
        public string NHSNumber { get; }
        public string TestName { get; }
        public string SpecNumber { get; set; }
        public string Collected { get; set; }
    }
}
