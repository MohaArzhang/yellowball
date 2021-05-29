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
using LibraryYellowBall;

namespace CustomerGUI
{
    public partial class UCBooking : UserControl
    {
        FinalProjectWPFEntitiesApril18 ctx;

        public UCBooking()
        {
            try
            {
                InitializeComponent();
                ctx = new FinalProjectWPFEntitiesApril18();      // exception
                comboTrain.ItemsSource = (from t in ctx.Trainers select t).ToList<Trainer>();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message, "Database operation failed", MessageBoxButton.OK, MessageBoxImage.Error);
                Environment.Exit(1);
            }

        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            gridBookNowUC.Visibility = Visibility.Hidden;
        }

        private void btnCheckOut_Click(object sender, RoutedEventArgs e)
        {
            if (comboCourt.SelectedItem == null || comboSession.SelectedItem == null || dpDate.SelectedDate.Value == null)
            {
                MessageBox.Show("A book must contain court number, date and session time.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }


            // check availability of booking
            string currSession = comboSession.Text;
            DateTime currDate = dpDate.SelectedDate.Value;
            int currCourt = comboCourt.SelectedIndex + 1;
            string trainerName = comboTrain.Text;
            int trainId = 0;
            if (trainerName != null)
            {
                var selectedTrainer = ctx.Trainers.Where(t => t.Name == trainerName);
                foreach (var item in selectedTrainer)
                {
                    trainId = item.TrainerId;
                }
            }
            bool isBooked = ctx.Bookings.Any(b => b.SessionTime == currSession && b.CourtId == currCourt && b.Date == currDate);
            bool bookedTrainer = ctx.Bookings.Any(b => b.SessionTime == currSession && b.TrainerId == trainId && b.Date == currDate);
            if (bookedTrainer == true)
            {
                MessageBox.Show("This trainer is not available at this time.", "Booking Error", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }

            bool available = true;
            var court = ctx.Courts.Where(c => c.CourtId == currCourt);
            foreach (var item in court)
            {
                available = item.Available;
            }
            if (isBooked == true || available == false)
            {
                MessageBox.Show("This Court is not available at this time , please pick another court, date or session.", "Booking Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            else
            {
                LibraryYellowBall.Booking book = new LibraryYellowBall.Booking();
                BookingDLG dlg = new BookingDLG(book);
                dlg.ParentWindow = this;
                dlg.Show();
            }
        }

        private void radio_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int custID = Convert.ToInt32(lblIDnum.Content);
                var selected = ctx.Customers.Where(c => c.CustId == custID);
                string member = "";
                double percentage = 1;
                foreach (var item in selected)
                {
                    member = item.Membership;
                }
                switch (member)
                {
                    case "Gold":
                        percentage = 0.75;
                        break;
                    case "Silver":
                        percentage = 0.85;
                        break;
                }
                double train = 0;
                double equip = 0;
                if (comboTrain.SelectedItem != null)
                {
                    train = 40;
                }
                if (radioYes.IsChecked == true)
                {
                    equip = 10;
                }
                double total = train + equip + 25;
                lblTotal.Content = total;
                lblPayment.Content = total * percentage;
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message, "Database operation failed", MessageBoxButton.OK, MessageBoxImage.Error);
                Environment.Exit(1);
            }
        }

        private void combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                int custID = Convert.ToInt32(lblIDnum.Content);
                var selected = ctx.Customers.Where(c => c.CustId == custID);
                string member = "";
                double percentage = 1;
                foreach (var item in selected)
                {
                    member = item.Membership;
                }
                switch (member)
                {
                    case "Gold":
                        percentage = 0.75;
                        break;
                    case "Silver":
                        percentage = 0.85;
                        break;
                }
                double train = 0;
                double equip = 0;
                if (comboTrain.SelectedItem != null)
                {
                    train = 40;
                }
                if (radioYes.IsChecked == true)
                {
                    equip = 10;
                }
                double total = train + equip + 25;
                lblTotal.Content = total;
                lblPayment.Content = total * percentage;
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message, "Database operation failed", MessageBoxButton.OK, MessageBoxImage.Error);
                Environment.Exit(1);
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            comboCourt.SelectedItem = null;
            dpDate.SelectedDate = DateTime.Now;
            comboSession.SelectedItem = null;
            comboTrain.SelectedItem = null;
            radioYes.IsChecked = true;
            lblPayment.Content = 0;
            lblTotal.Content = 0;
        }
    }
}
