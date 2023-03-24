using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingReportGenerator.UI.Models
{
    public class LaboratoryModel
    {
        public string LabName { get; set; }
        public IEnumerable<OutstandingDetailsModel> Items { get; }
        public LaboratoryModel(string labName, IEnumerable<OutstandingDetailsModel> items)
        {
            LabName = labName;
            Items = items;
        }
    }
}
