using OutstandingReportGenerator.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingReportGenerator.UI.Stores
{
    public class AppStore
    {
		private Labratory _selectedLaboratory;
		private IEnumerable<Labratory> _laboratories;
		
		
		public Labratory SelectedLaboratory
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

		public IEnumerable<Labratory> Labratories
    {
			get { return _laboratories; }
    }

		public event Action? SelectedLaboratoryChanged;

		public AppStore(IEnumerable<Labratory> labratories)
    {
			_laboratories = labratories;
			_selectedLaboratory = labratories.First();
    }
  }
}
