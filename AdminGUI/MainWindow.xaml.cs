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

namespace AdminGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnManageCustomer_Click(object sender, RoutedEventArgs e)
        {
            ManageCustomer cust = new ManageCustomer();
            gridTotal.Children.Add(cust);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnTrainer_Click(object sender, RoutedEventArgs e)
        {
            ManageTrainerUC train = new ManageTrainerUC();
            gridTotal.Children.Add(train);
        }

        private void btnCourt_Click(object sender, RoutedEventArgs e)
        {
            ManageCourtUC manage = new ManageCourtUC();
            gridTotal.Children.Add(manage);
        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            Report1UC report = new Report1UC();
            gridTotal.Children.Add(report);
            //report.PieChartLoad();
        }
    }
}
