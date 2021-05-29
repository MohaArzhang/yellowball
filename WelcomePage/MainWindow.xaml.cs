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

namespace WelcomePage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public UserControl ParentControl { get; set; }
        public static void CloseMain()
        {

        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBook_Click(object sender, RoutedEventArgs e)
        {
            UCLogin bookNow = new UCLogin();
            gridWelcome.Children.Add(bookNow);
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            UCLogin bookNow = new UCLogin();
            gridWelcome.Children.Remove(bookNow);
        }
    }
}
