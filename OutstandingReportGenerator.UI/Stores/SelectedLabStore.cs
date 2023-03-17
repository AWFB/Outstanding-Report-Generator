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
		private OutstandingDetailsModel _selectedLaboratory;
		
		
		public OutstandingDetailsModel SelectedLaboratory
        {
			get
			{
				return _selectedLaboratory;
			}
			set
			{
                _selectedLaboratory = value;
				SelectedLaboratoryChanged?.Invoke();
			}
		}

		public event Action SelectedLaboratoryChanged;
	}
}
