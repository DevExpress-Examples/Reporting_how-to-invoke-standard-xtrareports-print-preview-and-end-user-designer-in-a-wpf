using System;
using System.Windows;
using System.Windows.Threading;
using DevExpress.XtraReports.UI;
// ...

namespace WpfXtraReports {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        // Create a report instance.
        readonly XtraReport1 report = new XtraReport1();

        public MainWindow() {
            InitializeComponent();
        }

        // Implement the RaiseIdle method for the application.
        static MainWindow() {
            InvokeOnIdle();
        }
        static void InvokeOnIdle() {
            Dispatcher.CurrentDispatcher.BeginInvoke(new Action(OnIdle),
                DispatcherPriority.ApplicationIdle);
        }
        static void OnIdle() {
            InvokeOnIdle();
            System.Windows.Forms.Application.RaiseIdle(EventArgs.Empty);
        }

        // Invoke the Print Preview and End-User Report Designer windows.
        private void button1_Click(object sender, RoutedEventArgs e) {
            using (ReportPrintTool printTool = new ReportPrintTool(report)) {
                printTool.ShowPreviewDialog();
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e) {
            using (ReportDesignTool printTool = new ReportDesignTool(report)) {
                printTool.ShowDesignerDialog();
            }
        }
    }
}
