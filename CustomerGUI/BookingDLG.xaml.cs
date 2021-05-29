using System;
using System.Collections.Generic;
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

namespace CustomerGUI
{
    /// <summary>
    /// Interaction logic for BookingDLG.xaml
    /// </summary>
    public partial class BookingDLG : Window
    {
        public UCBooking ParentWindow { get; set; }
        FinalProjectWPFEntitiesApril18 ctx;
        int currentBook;
        public BookingDLG(Booking book)
        {
            InitializeComponent();
            ctx = new FinalProjectWPFEntitiesApril18();
            currentBook = book.BookingId;
        }

        private void btnPay_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(tbNumber.Text, @"^([0-9]{16})$"))
            {
                MessageBox.Show("Card number is not correct.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            if (!Regex.IsMatch(tbExDate.Text, @"^([0-9]{4}\-[0-9]{2}\-[0-9]{2})$"))
            {
                MessageBox.Show("Date format is not correct. Correct format: 2020-01-01", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            if (!Regex.IsMatch(tbCCV2.Text, @"^([0-9]{3})$"))
            {
                MessageBox.Show("CCV2 is not correct.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            string trainerName = ParentWindow.comboTrain.Text;
            int trainId = 0;
            var selectedTrainer = ctx.Trainers.Where(t => t.Name == trainerName);
            foreach (var item in selectedTrainer)
            {
                trainId = item.TrainerId;
            }
            int custID = Convert.ToInt32(ParentWindow.lblIDnum.Content);
            string custName = ParentWindow.lblCustName.Content.ToString();
            int courtID = ParentWindow.comboCourt.SelectedIndex + 1;
            DateTime bookDate = DateTime.Now;
            DateTime reserveDate = ParentWindow.dpDate.SelectedDate.Value;
            string sessionTime = ParentWindow.comboSession.Text;
            bool equipment = false;
            int pay = Convert.ToInt32(ParentWindow.lblPayment.Content);
            if (ParentWindow.radioNo.IsChecked == false)
            {
                equipment = true;
            }
            Booking book = new Booking { CustId = custID, TrainerId = trainId, CourtId = courtID, BookDate = bookDate, Date = reserveDate, SessionTime = sessionTime, Equipment = equipment, PayAmount = pay };
            if (trainId == 0)
            {
                book.TrainerId = null;
            }
            try
            {
                ctx.Bookings.Add(book);
                ctx.SaveChanges();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message, "Database operation failed", MessageBoxButton.OK, MessageBoxImage.Error);
                Environment.Exit(1);
            }
            ParentWindow.comboCourt.SelectedItem = null;
            ParentWindow.dpDate.SelectedDate = DateTime.Now;
            ParentWindow.comboSession.SelectedItem = null;
            ParentWindow.comboTrain.SelectedItem = null;
            ParentWindow.radioYes.IsChecked = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
