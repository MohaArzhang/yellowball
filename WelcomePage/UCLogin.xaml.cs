using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WelcomePage
{

    public partial class UCLogin : UserControl
    {
        CustomerGUI.FinalProjectWPFEntities1 ctx;
        public UCLogin()
        {
            try
            {
                InitializeComponent();
                ctx = new CustomerGUI.FinalProjectWPFEntities1();      // exception
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message, "Database operation failed.", MessageBoxButton.OK, MessageBoxImage.Error);
                Environment.Exit(1);
            }
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            UCLoginWindow.Visibility = Visibility.Hidden;
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            UCRegister regUC = new UCRegister();
            UCLoginWindow.Children.Add(regUC);
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var result = ctx.Customers.Where(c => c.UserName == tbUserName.Text).ToList();
            string user = "";
            foreach (var item in result)
            {
                user = item.UserName;
            }
            if (result.Count == 0)
            {
                MessageBox.Show("The username doesn't exist.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            string pass = "";
            foreach (var item in result)
            {
                pass = item.Password;
            }
            if (passbxPass.Password != pass)
            {
                MessageBox.Show("Password is not correct.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            if (passbxPass.Password == null || tbUserName.Text == null)
            {
                MessageBox.Show("Please fill username and passwords fields.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            CustomerGUI.MainWindow schedule = new CustomerGUI.MainWindow();
            schedule.Show();
            this.Visibility = Visibility.Hidden;
            

            var welcomeMain = Window.GetWindow(this);
            welcomeMain.Visibility = Visibility.Hidden;
            //welcomeMain.Close();
        }
    }
}
