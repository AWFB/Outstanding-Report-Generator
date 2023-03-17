using OutstandingReportGenerator.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingReportGenerator.UI.ViewModels;

public class LaboratoryListItemViewModel : ViewModelBase
{
  public String Name { get; private set; }
  public Labratory Labratory { get; private set; }

  public LaboratoryListItemViewModel(Labratory labratory)
  {
    Name = labratory.Name;
    Labratory = labratory;
  }
}
