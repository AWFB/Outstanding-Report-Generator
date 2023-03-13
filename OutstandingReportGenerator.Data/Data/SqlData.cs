using OutstandingReportGenerator.Data.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingReportGenerator.Data.Data;

public class SqlData : ISqlData
{
    private readonly ISqlDataAccess _db;
    private const string connectionStringName = "SqlDb";

    public SqlData(ISqlDataAccess db)
    {
        _db = db;
    }


    public void SaveCSVData(string path)
    {
        var data = new CsvDataAccess();
        List<CSVInputModel> input = data.ReadCsvFromFile(path);

        foreach (var item in input)
        {
            _db.SaveData("dbo.spCsvData_InsertData",
                new
                {
                    specNumber = item.SpecNumber,
                    barcode = item.BarCode,
                    collected = item.Collected,
                    unitNumber = item.UnitNumber,
                    testRequested = item.TestRequested,
                    refLabName = item.RefLabName,
                    resultInMeditech = item.ResultInMeditech,
                    nhsNumber = item.NHSNumber,
                    patientName = item.PatientName,
                    dateOfBirth = item.DateOfBirth

                }, connectionStringName, true);
        }
    }

    public static List<CSVInputModel> LoadCsvData(string path)
    {
        var data = new CsvDataAccess();
        List<CSVInputModel> output = data.ReadCsvFromFile(path);

        return output;
    }






}
