using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Threading;
using LibraryYellowBall;

namespace CustomerGUI
{
    /// <summary>
    /// Interaction logic for EditBookingDLG.xaml
    /// </summary>
    public partial class EditBookingDLG : Window
    {
        FinalProjectWPFEntitiesApril18 ctx;
        Booking currentBook;
        public Trainer trainer;
        public EditBookingDLG(Booking book)
        {
            currentBook = book;
            InitializeComponent();
            ctx = new FinalProjectWPFEntitiesApril18();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += timer_Date;
            timer.Start();
            selectedBookvalue();
        }
        private void selectedBookvalue()
        {
            dpDate.SelectedDate = currentBook.Date;
            comboCourt.SelectedIndex = Convert.ToInt32(currentBook.CourtId);
            comboSession.SelectedValue = currentBook.SessionTime.ToString();
            lblBookingId.Content = currentBook.BookingId;
            rbEquipment_Yes.IsChecked = currentBook.Equipment;

            Trainer traine = (from t in ctx.Trainers select t).FirstOrDefault<Trainer>();

            Trainer Currtrainer = ctx.Trainers.Where(s => s.TrainerId == currentBook.TrainerId).FirstOrDefault<Trainer>();
            if (Currtrainer != null)
            {
                lblTrainerName.Content = Currtrainer.Name;
            }
            comboTrainer.ItemsSource = (from t in ctx.Trainers select t).ToList<Trainer>();
        }

        private void btUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime.TryParse(dpDate.Text,
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out DateTime date);

            if (date == null || comboCourt.SelectedItem == null || comboSession.SelectedItem == null || dpDate.SelectedDate.Value == null)
            {
                MessageBox.Show("A book must contain court number, date and session time.", "Input error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            int TrainerID = Convert.ToInt32(comboTrainer.SelectedValue);

            currentBook.CourtId = comboCourt.SelectedIndex;
            currentBook.BookDate = date;
            currentBook.SessionTime = comboSession.Text;
            currentBook.TrainerId = TrainerID;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Parsing Error.", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            try
            {
            ctx.SaveChanges();
                if (currentBook != null)
                {

                }
                DialogResult = true;
                //this.Close();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message, "Database operation failed", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        void timer_Date(object sender, EventArgs e)
        {
            lblDateTime.Content = DateTime.Now.ToString("dddd , MMM dd yyyy,   hh:mm");
        }

        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            e.Handled = true;
        }

        private void comboTrainer_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            DateTime.TryParse(dpDate.Text,
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out DateTime date);
            bool bookedSessionTrainer1 = ctx.Bookings.Any(b => b.SessionTime == currentBook.SessionTime && b.TrainerId == currentBook.TrainerId && b.Date == date);

            if (bookedSessionTrainer1)
            {
                MessageBox.Show("This trainer is not available at this time.", "Booking Error", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
        }

        private void comboCourt_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            bool isBooked = ctx.Bookings.Any(b => b.SessionTime == currentBook.SessionTime && b.CourtId == currentBook.CourtId && b.Date == currentBook.BookDate);

            bool available = true;
            var court = ctx.Courts.Where(c => c.CourtId == currentBook.CourtId);
            foreach (var item in court)
            {
                available = item.Available;
            }
            if (isBooked == true || available == false)
            {
                MessageBox.Show("This Court is Booked at this time , please pick another court, date or session.", "Booking Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
        }
    }
}