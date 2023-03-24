using OutstandingReportGenerator.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.ViewModels
{
    public class OutstandingTestsTableVM
    {
      

        public ObservableCollection<CSVInputModel> Outstanding { get; set; }

        public OutstandingTestsTableVM()
        {
            CsvDataAccess da = new CsvDataAccess();

            Outstanding = new ObservableCollection<CSVInputModel>(da.ReadCsvFromFile(@"C:\Users\Sider\Desktop\test\outstanding.csv"));
        }
    }
}
