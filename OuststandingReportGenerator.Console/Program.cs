

using OutstandingReportGenerator.Data.Data;
using OutstandingReportGenerator.Data.Databases;

//var data = SqlData.LoadCsvData(@"C:\Users\Sider\Desktop\test\outstanding.csv");

//foreach (var item in data)
//{
//    Console.WriteLine($"{item.PatientName}");
//}

var foo = new SqlData(ISqlDataAccess db);

foo.SaveCSVData(@"C:\Users\Sider\Desktop\test\outstanding.csv");