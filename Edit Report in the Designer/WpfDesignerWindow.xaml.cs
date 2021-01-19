using Stimulsoft.Report;
using System.Windows;

namespace Edit_Report_in_the_Designer
{
    /// <summary>
    /// Interaction logic for WpfDesignerWindow.xaml
    /// </summary>
    public partial class WpfDesignerWindow : Window
    {
        public WpfDesignerWindow()
        {
            InitializeComponent();
        }

        private void ButtonNew_Click(object sender, RoutedEventArgs e)
        {
            StiWpfDesignerControl1.Report = new StiReport();
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            var report = new StiReport();
            report.Load(@"Reports\SimpleList.mrt");
            StiWpfDesignerControl1.Report = report;
        }
    }
}
