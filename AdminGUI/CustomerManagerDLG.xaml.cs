using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using LibraryYellowBall;
using CustomerGUI;
using Microsoft.Win32;
using CustomerGUI;

namespace AdminGUI
{
    /// <summary>
    /// Interaction logic for CustomerManagerDLG.xaml
    /// </summary>
    public partial class CustomerManagerDLG : Window
    {
        FinalProjectWPFEntitiesApril18 ctx;
        byte[] currentImage;
        int custId = 0;
        public ManageCustomer ParentWindow { get; set; }
        Customer currentCustomer;

        public CustomerManagerDLG(Customer customer)
        {
            try
            {
                InitializeComponent();
                ctx = new FinalProjectWPFEntitiesApril18();      // exception
                currentCustomer = customer;
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message, "Database operation failed.", MessageBoxButton.OK, MessageBoxImage.Error);
                Environment.Exit(1);
            }
            tbName.Text = currentCustomer.Name;
            tbAddress.Text = currentCustomer.Address;
            tbPC.Text = currentCustomer.PostalCode;
            tbPhone.Text = currentCustomer.Phone;
            tbEmail.Text = currentCustomer.Email;
            comboMember.Text = currentCustomer.Membership;
            tbUser.Text = currentCustomer.UserName;
            tbPass.Text = currentCustomer.Password;
            showImage.Source = Utility.ByteToImage(currentCustomer.Photo);
            currentImage = currentCustomer.Photo;
            custId = currentCustomer.CustId;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            CheckVslidation();

            // Update database
            try
            {
                var custRow = ctx.Customers.Where(c => c.CustId == custId).FirstOrDefault();    // exception
                custRow.Name = tbName.Text;
                custRow.Address = tbAddress.Text;
                custRow.PostalCode = tbPC.Text;
                custRow.Phone = tbPhone.Text;
                custRow.Email = tbEmail.Text;
                custRow.Membership = comboMember.Text;
                custRow.UserName = tbUser.Text;
                custRow.Password = tbPass.Text;
                custRow.Photo = currentImage;
                ctx.SaveChanges();
                List<Customer> customer = (from c in ctx.Customers where c.CustId == custId select c).ToList<Customer>();  //exception
                ParentWindow.lvCustomer.ItemsSource = customer;
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Database Error!:\n" + ex.Message, "Database Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ParentWindow.lvCustomer.Items.Refresh();
            Utility.AutoResizeColumns(ParentWindow.lvCustomer);
            this.Close();
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            CheckVslidation();
            // Username existance validation
            string user = tbUser.Text;
            string checkUser = "";
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
            string name = tbName.Text;
            string address = tbAddress.Text;
            string post = tbPC.Text;
            string phone = tbPhone.Text;
            string email = tbEmail.Text;
            DateTime dob = dpBirth.SelectedDate.Value;
            string member = comboMember.Text;
            string pass = tbPass.Text;
            DateTime regDate = DateTime.Today;
            Customer customer = new Customer { Name = name, Address = address, PostalCode = post, Phone = phone, Email = email, DOB = dob, Membership = member, UserName = tbUser.Text, Password = pass, Photo = currentImage, RegistrationDate = regDate };
            ctx.Customers.Add(customer);
            ctx.SaveChanges();
            this.Close();
        }

        public void CheckVslidation()
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

            // Password validation
            if (!Regex.IsMatch(tbPass.Text, @"^([a-zA-Z0-9_\-\.\@\$\%\&]{4,8})$"))
            {
                MessageBox.Show("Password can contain 4-8 letters, numbers and @ $ % & . - _", "Password Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
        }
    }
}
