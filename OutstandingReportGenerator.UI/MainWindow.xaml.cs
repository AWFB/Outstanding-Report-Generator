using OutstandingReportGenerator.Data.Data;
using OutstandingReportGenerator.Data.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OutstandingReportGenerator.UI
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}

//public partial class MainWindow : Window
//{
//    private readonly ISqlData _db;

//    public MainWindow(ISqlData db)
//    {
//        InitializeComponent();
//        _db = db;
//    }

//    private void getData_Click(object sender, RoutedEventArgs e)
//    {
//        _db.SaveCSVData(@"C:\Users\Sider\Desktop\test\outstanding.csv");
//    }
//}
