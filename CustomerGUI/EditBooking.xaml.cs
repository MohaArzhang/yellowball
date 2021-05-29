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
using System.Windows.Shapes;
using LibraryYellowBall;

namespace CustomerGUI
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class EditBooking : Window
    {
        //Booking CurrBook;
        public List<Booking> bookingList = new List<Booking>();
        FinalProjectWPFEntitiesApril18 ctx;
        private string currentCustID;

        public EditBooking(string currCustID)
        {
            InitializeComponent();
            try
            {
                this.currentCustID = currCustID;
                ctx = new FinalProjectWPFEntitiesApril18();
                LoadData();
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Fatal Error Connecting to Database:\n" + ex.Message, "Database Connection Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                Environment.Exit(1);
            }
        }

        private void LoadData()
        {
            try
            {
                int currCusID; //= Convert.ToInt32(lblCusID.Content);
                if (int.TryParse(currentCustID.ToString(), out currCusID))
                bookingList = (from booking in ctx.Bookings where booking.CustId == currCusID select booking).ToList<Booking>();
                lvBookings.ItemsSource = bookingList;
                lvBookings.Items.Refresh();
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Database Error!:\n" + ex.Message, "Database Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
        public void RefreshPage()
        {
            btDelete.IsEnabled = false;
            btEdit.IsEnabled = false;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gridEdit.Visibility = Visibility.Hidden;
        }

        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            Booking bookingCurr = (Booking)lvBookings.SelectedItem;

            if (bookingCurr == null) { return; } 

            try
            {

                MessageBoxResult result = MessageBox.Show("Are you Sure You want Delete this Session?", "Session Remove", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);

                if (result == MessageBoxResult.Yes)
                {
                    ctx.Bookings.Remove(bookingCurr);
                    ctx.SaveChanges();
                    lvBookings.ItemsSource = ctx.Bookings.ToList();
                    refreshBook();
                }
                else return;
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message, "Database operation failed", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var obj = (DependencyObject)e.OriginalSource;
            while (obj != null && obj != lvBookings)
            {
                if (obj.GetType() == typeof(ListViewItem))
                {  // Do something here
                    Booking CurrBook = (Booking)lvBookings.SelectedItem;
                    EditBookingDLG dlg = new EditBookingDLG(CurrBook);
                    dlg.Owner = this;
                    bool? result = dlg.ShowDialog();
                    if (result == true)
                    {
                        refreshBook();
                    }
                    break;
                }
                obj = VisualTreeHelper.GetParent(obj);
            }
        }

        private void lvBookings_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvBookings.SelectedIndex == -1)
            {
                RefreshPage();
                return;
            }
            btEdit.IsEnabled = true;
            btDelete.IsEnabled = true;
        }

        private void refreshBook()
        {
            try
            {
                int currCusID;
                List<Booking> bookingList = new List<Booking>();
                if (int.TryParse(currentCustID.ToString(), out currCusID))
                    bookingList = (from booking in ctx.Bookings where booking.CustId == currCusID select booking).ToList<Booking>();
                lvBookings.ItemsSource = bookingList;
                lvBookings.Items.Refresh();
                Utility.AutoResizeColumns(lvBookings);
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Fatal Error Connecting to Database:\n" + ex.Message, "Database Connection Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                Environment.Exit(1);
            }
        }
        
        private void itemRemove_Click(object sender, RoutedEventArgs e)
        {
            btDelete_Click(sender, e);
            e.Handled = true;
        }

        private void itemEdit_Click(object sender, RoutedEventArgs e)
        {
            btEdit_Click(sender, e);
            e.Handled = true;
        }

        private void btEdit_Click(object sender, RoutedEventArgs e)
        {
            Booking CurrBook = (Booking)lvBookings.SelectedItem;
            EditBookingDLG dlg = new EditBookingDLG(CurrBook);
            dlg.Owner = this;
            bool? result = dlg.ShowDialog();
            if (result == true)
            {
                refreshBook();
            }
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
            MainWindow main = new MainWindow();
            main.CurrUserLbl.Content = lblCust.Content;
            main.CurrUserLbl.Content = lblCusName.Content;
            main.lblUserIdHidden.Content = lblCusID.Content;
            main.CurrUserImg.Source = custImage.Source;
            main.Visibility = Visibility.Visible;
        }
    }
}