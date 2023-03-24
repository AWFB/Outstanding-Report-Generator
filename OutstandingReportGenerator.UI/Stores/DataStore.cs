using OutstandingReportGenerator.Data;
using OutstandingReportGenerator.UI.Models;
using OutstandingReportGenerator.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace OutstandingReportGenerator.UI.Stores
{
    public class DataStore
    {
        private readonly ObservableCollection<OutstandingDetailsModel> _outstanding;


        public ObservableCollection<OutstandingDetailsModel> Outstanding => _outstanding;

        public DataStore()
        {
            _outstanding = new ObservableCollection<OutstandingDetailsModel>();
        }

        public void Load(string path)
        {
            CsvDataAccess da = new CsvDataAccess();

            _outstanding.Clear();
            foreach (var inputModel in da.ReadCsvFromFile(path)) 
            {
                _outstanding.Add(new OutstandingDetailsModel(inputModel));
            }
        }
    }
}
