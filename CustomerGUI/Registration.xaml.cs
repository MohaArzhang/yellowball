using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using LibraryYellowBall;
using System.Text.RegularExpressions;
using CustomerGUI;

namespace CustomerGUI
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : UserControl
    {
        FinalProjectWPFEntitiesApril18 ctx;
        byte[] currentImage;
        public Registration()
        {
            try
            {
                InitializeComponent();
                ctx = new FinalProjectWPFEntitiesApril18();      // exception
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message, "Database operation failed.", MessageBoxButton.OK, MessageBoxImage.Error);
                Environment.Exit(1);
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            gridRegister.Visibility = Visibility.Hidden;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            //All fields not empty validation
            if (tbName.Text == null || tbAddress.Text == null || tbPC.Text == null || tbPhone.Text == null || tbEmail.Text == null || dpBirth.SelectedDate == null || comboMember.SelectedIndex == 0 || tbUser.Text == null || tbPass.Text == null || showImage.Source == null)
            {
                MessageBox.Show("Text fields and image can not be empty.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            // Postal Code validation
            if (!Regex.IsMatch(tbPC.Text, @"^([A-Z0-9]{3})\ ([A-Z0-9]{3})$"))
            {
                MessageBox.Show("Postal Code Format must be as A2A 2A2.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            // Phone validation
            if (!Regex.IsMatch(tbPhone.Text, @"^\([0-9]{3}\)[0-9]{3}\-[0-9]{4}$"))
            {
                MessageBox.Show("Phone format must be as (000)000-0000", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            // Email validation
            if (!Regex.IsMatch(tbEmail.Text, @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$"))
            {
                MessageBox.Show("Email format is not correct.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            // Username existance validation
            string user = tbUser.Text;
            string checkUser = "";
            //var test = (from c in ctx.Customers select c).ToList<Customer>();
            var userCheck = ctx.Customers.Where(c => c.UserName == tbUser.Text).ToList();
            foreach (var item in userCheck)
            {
                Console.WriteLine(item.Name);
                checkUser = item.Name;
                Console.WriteLine(checkUser);
            }
            if (checkUser != "")
            {
                MessageBox.Show("The username existes, please choose another username.", "Username Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                checkUser = "";
                return;
            }

            // Password validation
            if (!Regex.IsMatch(tbPass.Text, @"^([a-zA-Z0-9_\-\.\@\$\%\&]{4,8})$"))
            {
                MessageBox.Show("Password can contain 4-8 letters, numbers and @ $ % & . - _", "Password Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            string name = tbName.Text;
            string address = tbAddress.Text;
            string post = tbPC.Text;
            string phone = tbPhone.Text;
            string email = tbEmail.Text;
            DateTime dob = dpBirth.SelectedDate.Value;
            string member = comboMember.Text;



            string pass = tbPass.Text;
            DateTime regDate = DateTime.Today;
            Customer customer = new Customer { Name = name, Address = address, PostalCode = post, Phone = phone, Email = email, DOB = dob, Membership = member, UserName = user, Password = pass, Photo = currentImage, RegistrationDate = regDate };
            ctx.Customers.Add(customer);
            ctx.SaveChanges();
            gridRegister.Visibility = Visibility.Hidden;
        }

        private void btnAddImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image files (*.jpg;*.jpeg;*.gif;*.png)|*.jpg;*.jpeg;*.gif;*.png|All Files (*.*)|*.*";

            if (dlg.ShowDialog() == true)
            {
                try
                {
                    currentImage = File.ReadAllBytes(dlg.FileName);     // IOException
                    tbAddImage.Visibility = Visibility.Hidden;
                    BitmapImage thumbnail = Utility.ByteToImage(currentImage);        // SystemException
                    showImage.Source = thumbnail;
                }
                catch (Exception ex) when (ex is SystemException || ex is IOException)
                {
                    MessageBox.Show(ex.Message, "File reading failed", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }
    }
}
