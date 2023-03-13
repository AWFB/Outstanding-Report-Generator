using CsvHelper.Configuration.Attributes;

namespace OutstandingReportGenerator.Data
{
    public class CSVInputModel
    {
        [Name("S#")] public string SpecNumber { get; set; }
        [Name("B/C#")] public string BarCode { get; set; }
        [Name("STATUS")] public string Status { get; set; }
        [Name("COLLECTED")] public string Collected { get; set; }
        [Name("UNIT#")] public string UnitNumber { get; set; }
        [Name("PATIENT")] public string PatientDetails { get; set; }
        [Name("TEST REQUIRED")] public string TestRequested { get; set; }
        [Name("SEND TO")] public string RefLabName { get; set; }
        [Name("ANY RESULT")] public string ResultInMeditech { get; set; }

        public string NHSNumber
        {
            get
            {
                // Extract NHS number from patientdetails
                // example string: "RIKER,WILLIAM (01/01/2042  NHS# 111 222 3333)")
                string requiredString = PatientDetails.Split('#', ')')[1];

                return requiredString;
            }
            
        }

        public string PatientName
        {
            get
            {
                // Extract NHS number from patientdetails
                // example string: "RIKER,WILLIAM (01/01/2042  NHS# 111 222 3333)")
                string requiredString = PatientDetails.Substring(0, PatientDetails.IndexOf('('));

                return requiredString;
            }
            
        }

        public string DateOfBirth
        {
            get
            {
                // Extract NHS number from patientdetails
                // example string: "RIKER,WILLIAM (01/01/2042  NHS# 111 222 3333)"
                int index = PatientDetails.IndexOf('(') + 1;
                string requiredString = PatientDetails.Substring(index, 10);

                return requiredString;
            }
            
        }
    }
}
