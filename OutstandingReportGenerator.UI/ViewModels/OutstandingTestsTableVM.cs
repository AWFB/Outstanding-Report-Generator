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
    private readonly SelectedLabStore _selectedLabStore;

    public ObservableCollection<OutstandingDetailsModel> Outstanding => _filteredOutstanding;
    private ObservableCollection<OutstandingDetailsModel> _filteredOutstanding;

    public OutstandingTestsTableVM(DataStore dataStore, SelectedLabStore selectedLabStore)
    {
        _dataStore = dataStore;
        _selectedLabStore = selectedLabStore;
        _filteredOutstanding = new ObservableCollection<OutstandingDetailsModel>();

        _selectedLabStore.SelectedLabNameChanged += _selectedLabStore_SelectedLabNameChanged;
    }

    private void _selectedLabStore_SelectedLabNameChanged()
    {
        FilterOutstandingByLabName();
    }

    public void FilterOutstandingByLabName()
    {
        if (_selectedLabStore.SelectedLabName == null)
        {
            foreach (var item in _dataStore.Outstanding)
            {
                _filteredOutstanding.Add(item);
            }
        }
        else
        {
            var filter = _dataStore.Outstanding.Where(o => o.LabName == _selectedLabStore.SelectedLabName.LabName).ToList();

            _filteredOutstanding.Clear();
            foreach (var item in filter)
            {
                _filteredOutstanding.Add(item);
            }
        }

    }
}
