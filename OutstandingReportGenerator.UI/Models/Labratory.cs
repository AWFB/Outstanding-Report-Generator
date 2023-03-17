using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingReportGenerator.UI.Models
{
  public class Labratory
  {
    public string Name { get; set; }
    public IEnumerable<Item> Items { get; }

    public Labratory(string name, IEnumerable<Item> items)
    {
      Name = name;
      Items = items;
    }
  }
}
