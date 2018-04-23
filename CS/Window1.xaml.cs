using System;
using System.Windows;
using System.Windows.Threading;

namespace WpfXtraReports {

    public partial class Window1 : Window {

        public Window1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e) {
            new XtraReport1().ShowPreviewDialog();
        }

        private void button2_Click(object sender, RoutedEventArgs e) {
            new XtraReport1().ShowDesignerDialog();
        }
    }
}
