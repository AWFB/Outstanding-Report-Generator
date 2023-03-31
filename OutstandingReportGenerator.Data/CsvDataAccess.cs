using CsvHelper;
using System.Globalization;

namespace OutstandingReportGenerator.Data;

public class CsvDataAccess
{
    public List<CSVInputModel> ReadCsvFromFile(string path)
    {

        List<CSVInputModel> results = new List<CSVInputModel>();

        using (var reader = new StreamReader(path))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var records = csv.GetRecords<CSVInputModel>();

            foreach (var item in records)
            {
                results.Add(item);
            }
        }

        return results;

    }
}
