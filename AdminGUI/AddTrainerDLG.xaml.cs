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
using Microsoft.Win32;
using CustomerGUI;

namespace AdminGUI
{
    /// <summary>
    /// Interaction logic for AddTrainerDLG.xaml
    /// </summary>
    public partial class AddTrainerDLG : Window
    {
        public ManageTrainerUC ParentWindow { get; set; }
        FinalProjectWPFEntitiesApril18 ctx;
        byte[] currentImage;
        int trainId;

        public AddTrainerDLG(Trainer trainer)
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
            trainId = trainer.TrainerId;
            tbName.Text = trainer.Name;
            tbAddress.Text = trainer.Address;
            tbPC.Text = trainer.PostalCode;
            tbPhone.Text = trainer.Phone;
            showImage.Source = Utility.ByteToImage(trainer.Photo);
            currentImage = trainer.Photo;
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
            //All fields not empty validation
            if (tbName.Text == null || tbAddress.Text == null || tbPC.Text == null || tbPhone.Text == null || showImage.Source == null)
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

            string name = tbName.Text;
            string address = tbAddress.Text;
            string post = tbPC.Text;
            string phone = tbPhone.Text;
            DateTime regDate = DateTime.Today;
            Trainer trainer = new Trainer { Name = name, Address = address, PostalCode = post, Phone = phone, Photo = currentImage };
            ctx.Trainers.Add(trainer);
            ctx.SaveChanges();
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            //All fields not empty validation
            if (tbName.Text == null || tbAddress.Text == null || tbPC.Text == null || tbPhone.Text == null || showImage.Source == null)
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

            // Update database
            try
            {
                var trainerRow = ctx.Trainers.Where(c => c.TrainerId == trainId).FirstOrDefault();    // exception
                trainerRow.Name = tbName.Text;
                trainerRow.Address = tbAddress.Text;
                trainerRow.PostalCode = tbPC.Text;
                trainerRow.Phone = tbPhone.Text;
                trainerRow.Photo = currentImage;
                ctx.SaveChanges();
                List<Trainer> trainer = (from t in ctx.Trainers where t.TrainerId == trainId select t).ToList<Trainer>();  //exception
                ParentWindow.lvTrainer.ItemsSource = trainer;
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Database Error!:\n" + ex.Message, "Database Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ParentWindow.lvTrainer.Items.Refresh();
            Utility.AutoResizeColumns(ParentWindow.lvTrainer);
            this.Close();
        }
    }
}
