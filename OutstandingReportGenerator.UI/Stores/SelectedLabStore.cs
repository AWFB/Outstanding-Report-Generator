using OutstandingReportGenerator.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingReportGenerator.UI.Stores
{
    public class SelectedLabStore
    {
        private OutstandingDetailsModel _selectedLabName;

        // public property to get/set the selected lab name        
        public OutstandingDetailsModel SelectedLabName
        {
            get { return _selectedLabName; }
            set
            {
                if (_selectedLabName != value)
                {
                    _selectedLabName = value;
                    SelectedLabNameChanged?.Invoke();
                    // update the filtered outstanding list whenever the selected lab name changes

                }
            }
        }
        public event Action SelectedLabNameChanged;
    }
}
