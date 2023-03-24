using OutstandingReportGenerator.Data;
using OutstandingReportGenerator.UI.Models;
using OutstandingReportGenerator.UI.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace OutstandingReportGenerator.UI.ViewModels;

public class OutstandingTestsTableVM : ViewModelBase
{
    private DataStore _dataStore;

    public ObservableCollection<OutstandingDetailsModel> Outstanding => _dataStore.Outstanding;

    //public ICollectionView LabCollectionView { get; }

    public OutstandingTestsTableVM(DataStore dataStore)
    {
        _dataStore = dataStore;


        //LabCollectionView = CollectionViewSource.GetDefaultView(_dataStore.Outstanding);
        //LabCollectionView.Filter = item =>
        //{
        //    OutstandingDetailsModel lab = item as OutstandingDetailsModel;
        //    return Outstanding.Count(x => x.LabName == lab.LabName) == 1;

        //};
    }
}
