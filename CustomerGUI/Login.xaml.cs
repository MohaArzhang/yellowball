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


namespace CustomerGUI
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        LibraryYellowBall.FinalProjectWPFEntitiesApril18 ctx;
        byte[] currentImage;
        public Login()
        {
            try
            {
                InitializeComponent();
                ctx = new LibraryYellowBall.FinalProjectWPFEntitiesApril18();
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
            Registration regUC = new Registration();
            UCLoginWindow.Children.Add(regUC);
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var result = ctx.Customers.Where(c => c.UserName == tbUserName.Text).ToList();
            string user = "";
            string name = "";
            int idCust = 0;
            foreach (var item in result)
            {
                user = item.UserName;
                currentImage = item.Photo;
                name = item.Name;
                idCust = item.CustId;
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
            if (passbxPass.Password == null || tbUserName.Text == null)
            {
                MessageBox.Show("Please fill username and passwords fields.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            if (passbxPass.Password != pass)
            {
                MessageBox.Show("Password is not correct.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            MainWindow schedule = new MainWindow();
            BitmapImage thumb = Utility.ByteToImage(currentImage);
            schedule.CurrUserImg.Source = thumb;
            schedule.CurrUserLbl.Content = name;
            schedule.lblUserIdHidden.Content = idCust;
            this.Visibility = Visibility.Hidden;
            WelcomePage welcome = new WelcomePage();
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
            schedule.Show();
        }

        private void passbxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnLogin_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
