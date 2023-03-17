using OutstandingReportGenerator.UI.Models;
using OutstandingReportGenerator.UI.Stores;
using OutstandingReportGenerator.UI.ViewModels;
using System.Collections.Generic;
using System.Windows;

namespace OutstandingReportGenerator.UI
{
  public partial class App : Application
  {
    private readonly AppStore _appStore;

    public App()
    {
      _appStore = new AppStore(new[]
      {
                new Labratory(
                   "LAB 1",
                   new[] {
                      new Item("ABC", "Steve Smith", "01/02/03", "31512312", "Bum Test"),
                      new Item("DEF", "Bob Smith", "02/03/04", "643263425", "Scrotum Test"),
                      new Item("HIJ", "Sandy Smith", "03/04/05", "75442633", "Nipple Test"),
                    }
                ),
                new Labratory(
                   "LAB 2",
                   new[] {
                      new Item("KLM", "Mary Lamb", "04/05/06", "54737543456", "Covid Test"),
                      new Item("NOP", "Paul Tie", "05/06/07", "453884358", "Blood Test"),
                      new Item("QRS", "Joe King", "06/07/08", "4324232224", "Sausage Test"),
                    }
                ),
            });
    }

    protected override void OnStartup(StartupEventArgs e)
    {
      MainWindow = new MainWindow()
      {
        DataContext = new OutstandingTestsVM(_appStore)
      };
      MainWindow.Show();

      base.OnStartup(e);
    }
  }
}
