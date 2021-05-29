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

namespace WelcomePage
{
    /// <summary>
    /// Interaction logic for UCRegister.xaml
    /// </summary>
    public partial class UCRegister : UserControl
    {
        CustomerGUI.FinalProjectWPFEntities1 ctx;
        byte[] currentImage;
        public UCRegister()
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
            gridRegister.Visibility = Visibility.Hidden;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string name = tbName.Text;
            string address = tbAddress.Text;
            string post = tbPC.Text;
            string phone = tbPhone.Text;
            string email = tbEmail.Text;
            DateTime dob = dpBirth.SelectedDate.Value;
            string member = comboMember.Text;
            string user = tbUser.Text;
            string pass = tbPass.Text;
            DateTime regDate = DateTime.Today;
            CustomerGUI.Customer customer = new CustomerGUI.Customer { Name = name, Address = address, PostalCode = post, Phone = phone, Email = email, DOB = dob, Membership = member, UserName = user, Password = pass, Photo = currentImage, RegistrationDate = regDate };
            ctx.Customers.Add(customer);
            ctx.SaveChanges();
            gridRegister.Visibility = Visibility.Hidden;
        }

        public static BitmapImage ByteToImage(byte[] dataImage)
        {
            if (dataImage == null || dataImage.Length == 0) return null;
            var image = new BitmapImage();
            using (var mem = new MemoryStream(dataImage))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
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
                    BitmapImage thumbnail = ByteToImage(currentImage);        // SystemException
                    showImage.Source = thumbnail;
                }
                catch (Exception ex) when (ex is SystemException || ex is IOException)
                {
                    MessageBox.Show(ex.Message, "File reading failed", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }




        // THIS EVENT IS ONLY FOR TEST
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var result = ctx.Customers.Where(c => c.CustId == 29).ToList();
            //foreach (var item in result)
            //{
            //    currentImage = item.Photo;
            //}
            //BitmapImage thumb = ByteToImage(currentImage);
            //showImage.Source = thumb;
            ////CustomerGUI.Customer result = new CustomerGUI.Customer().ctx.Customers.Where(c => c.CustId == 29);
            ////var result = ctx.Customers.Where(c => c.CustId == 29);
            ////foreach (var item in result)
            ////{
            ////    Console.WriteLine(item.Name);
            ////    Console.WriteLine(item.Address);
            ////    Console.WriteLine(item.Photo);
            ////    Console.WriteLine(item.Phone);
            ////}
        }
    }
}
