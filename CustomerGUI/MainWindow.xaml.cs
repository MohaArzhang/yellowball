using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LibraryYellowBall;


namespace CustomerGUI
{

    public partial class MainWindow : Window
    {

        FinalProjectWPFEntitiesApril18 ctx;

        public MainWindow()
        {

            try
            {
                InitializeComponent();
                ctx = new FinalProjectWPFEntitiesApril18();
            }
            catch (SystemException ex)
            {

                MessageBox.Show(ex.Message, "Database Operation Failed ", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        //Book Button
        private void btnBook_Click(object sender, RoutedEventArgs e)
        {
            UCBooking bookNow = new UCBooking();
            bookNow.lblCustName.Content = CurrUserLbl.Content;
            bookNow.lblCustLeft.Content = CurrUserLbl.Content;
            bookNow.lblIDnum.Content = lblUserIdHidden.Content;
            bookNow.custImage.Source = CurrUserImg.Source;
            gridTotal.Children.Add(bookNow);


        }

        //Edit Button
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

            EditBooking edit = new EditBooking(lblUserIdHidden.Content.ToString());
            edit.lblCust.Content = CurrUserLbl.Content;
            edit.lblCusName.Content = CurrUserLbl.Content;
            edit.lblCusID.Content = lblUserIdHidden.Content;
            edit.custImage.Source = CurrUserImg.Source;
            edit.Show();
            this.Visibility = Visibility.Hidden;
        }

        DateTime dateTime;

        //Pick a Date from Calendar and display Booked and Free Courts
        private void cldSample_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                dateTime = DateTime.Parse(MWlbl_date.Content.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Parsing Error.", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            //   fill 20 Point regarding  20 query and 20 IF statement  (start--)

            bool state1 = ctx.Bookings.Any(b => b.Date == dateTime && b.CourtId == 1 && b.SessionTime == "10:00 AM");

            if (state1 == true)
            {

                P11.IsEnabled = false;
                P11.Visibility = Visibility.Hidden;
                B11.Background = new SolidColorBrush(Colors.Red);

            }

            bool state2 = ctx.Bookings.Any(b => b.Date == dateTime && b.CourtId == 2 && b.SessionTime == "10:00 AM");

            if (state2 == true)
            {
                P12.IsEnabled = false;
                P12.Visibility = Visibility.Hidden;
                B12.Background = new SolidColorBrush(Colors.Red);

            }


            bool state3 = ctx.Bookings.Any(b => b.Date == dateTime && b.CourtId == 3 && b.SessionTime == "10:00 AM");

            if (state3 == true)
            {
                P13.IsEnabled = false;
                P13.Visibility = Visibility.Hidden;
                B13.Background = new SolidColorBrush(Colors.Red);

            }
            bool state4 = ctx.Bookings.Any(b => b.Date == dateTime && b.CourtId == 4 && b.SessionTime == "10:00 AM");

            if (state4 == true)
            {

                P14.IsEnabled = false;
                P14.Visibility = Visibility.Hidden;
                B14.Background = new SolidColorBrush(Colors.Red);

            }

            bool state5 = ctx.Bookings.Any(b => b.Date == dateTime && b.CourtId == 1 && b.SessionTime == "12:00 PM");

            if (state5 == true)
            {
                P21.IsEnabled = false;
                P21.Visibility = Visibility.Hidden;
                B21.Background = new SolidColorBrush(Colors.Red);

            }

            bool state6 = ctx.Bookings.Any(b => b.Date == dateTime && b.CourtId == 2 && b.SessionTime == "12:00 PM");

            if (state6 == true)
            {
                P22.IsEnabled = false;
                P22.Visibility = Visibility.Hidden;
                B22.Background = new SolidColorBrush(Colors.Red);

            }

            bool state7 = ctx.Bookings.Any(b => b.Date == dateTime && b.CourtId == 3 && b.SessionTime == "12:00 PM");

            if (state7 == true)
            {
                P23.IsEnabled = false;
                P23.Visibility = Visibility.Hidden;
                B23.Background = new SolidColorBrush(Colors.Red);

            }

            bool state8 = ctx.Bookings.Any(b => b.Date == dateTime && b.CourtId == 4 && b.SessionTime == "12:00 PM");

            if (state8 == true)
            {
                P24.IsEnabled = false;
                P24.Visibility = Visibility.Hidden;
                B24.Background = new SolidColorBrush(Colors.Red);

            }

            bool state9 = ctx.Bookings.Any(b => b.Date == dateTime && b.CourtId == 1 && b.SessionTime == "2:00 PM");

            if (state9 == true)
            {
                P31.IsEnabled = false;
                P31.Visibility = Visibility.Hidden;
                B31.Background = new SolidColorBrush(Colors.Red);

            }

            bool state10 = ctx.Bookings.Any(b => b.Date == dateTime && b.CourtId == 2 && b.SessionTime == "2:00 PM");

            if (state10 == true)
            {
                P32.IsEnabled = false;
                P32.Visibility = Visibility.Hidden;
                B32.Background = new SolidColorBrush(Colors.Red);

            }

            bool state11 = ctx.Bookings.Any(b => b.Date == dateTime && b.CourtId == 3 && b.SessionTime == "2:00 PM");

            if (state11 == true)
            {
                P33.IsEnabled = false;
                P33.Visibility = Visibility.Hidden;
                B33.Background = new SolidColorBrush(Colors.Red);

            }

            bool state12 = ctx.Bookings.Any(b => b.Date == dateTime && b.CourtId == 4 && b.SessionTime == "2:00 PM");

            if (state12 == true)
            {
                P34.IsEnabled = false;
                P34.Visibility = Visibility.Hidden;
                B34.Background = new SolidColorBrush(Colors.Red);

            }

            bool state13 = ctx.Bookings.Any(b => b.Date == dateTime && b.CourtId == 1 && b.SessionTime == "4:00 PM");

            if (state13 == true)
            {
                P41.IsEnabled = false;
                P41.Visibility = Visibility.Hidden;
                B41.Background = new SolidColorBrush(Colors.Red);

            }

            bool state14 = ctx.Bookings.Any(b => b.Date == dateTime && b.CourtId == 2 && b.SessionTime == "4:00 PM");

            if (state14 == true)
            {
                P42.IsEnabled = false;
                P42.Visibility = Visibility.Hidden;
                B42.Background = new SolidColorBrush(Colors.Red);

            }

            bool state15 = ctx.Bookings.Any(b => b.Date == dateTime && b.CourtId == 3 && b.SessionTime == "4:00 PM");

            if (state15 == true)
            {
                P43.IsEnabled = false;
                P43.Visibility = Visibility.Hidden;
                B43.Background = new SolidColorBrush(Colors.Red);

            }

            bool state16 = ctx.Bookings.Any(b => b.Date == dateTime && b.CourtId == 4 && b.SessionTime == "4:00 PM");

            if (state16 == true)
            {
                P44.IsEnabled = false;
                P44.Visibility = Visibility.Hidden;
                B44.Background = new SolidColorBrush(Colors.Red);

            }


            bool state17 = ctx.Bookings.Any(b => b.Date == dateTime && b.CourtId == 1 && b.SessionTime == "6:00 PM");

            if (state17 == true)
            {
                P51.IsEnabled = false;
                P51.Visibility = Visibility.Hidden;
                B51.Background = new SolidColorBrush(Colors.Red);

            }

            bool state18 = ctx.Bookings.Any(b => b.Date == dateTime && b.CourtId == 2 && b.SessionTime == "6:00 PM");

            if (state18 == true)
            {
                P52.IsEnabled = false;
                P52.Visibility = Visibility.Hidden;
                B52.Background = new SolidColorBrush(Colors.Red);

            }

            bool state19 = ctx.Bookings.Any(b => b.Date == dateTime && b.CourtId == 3 && b.SessionTime == "6:00 PM");

            if (state19 == true)
            {
                P53.IsEnabled = false;
                P53.Visibility = Visibility.Hidden;
                B53.Background = new SolidColorBrush(Colors.Red);

            }

            bool state20 = ctx.Bookings.Any(b => b.Date == dateTime && b.CourtId == 4 && b.SessionTime == "6:00 PM");

            if (state20 == true)
            {
                P54.IsEnabled = false;
                P54.Visibility = Visibility.Hidden;
                B54.Background = new SolidColorBrush(Colors.Red);
            }
            //   fill 20 Point regarding  20 query and 20 IF statement  (End)

        }

        // Calendar Date change - Reset All Points state
        private void cldSample_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            P11.IsEnabled = true;
            P11.Visibility = Visibility.Visible;
            B11.Background = new SolidColorBrush(Colors.White);

            P21.IsEnabled = true;
            P21.Visibility = Visibility.Visible;
            B21.Background = new SolidColorBrush(Colors.White);

            P31.IsEnabled = true;
            P31.Visibility = Visibility.Visible;
            B31.Background = new SolidColorBrush(Colors.White);

            P41.IsEnabled = true;
            P41.Visibility = Visibility.Visible;
            B41.Background = new SolidColorBrush(Colors.White);

            P51.IsEnabled = true;
            P51.Visibility = Visibility.Visible;
            B51.Background = new SolidColorBrush(Colors.White);

            P12.IsEnabled = true;
            P12.Visibility = Visibility.Visible;
            B12.Background = new SolidColorBrush(Colors.White);

            P22.IsEnabled = true;
            P22.Visibility = Visibility.Visible;
            B22.Background = new SolidColorBrush(Colors.White);

            P32.IsEnabled = true;
            P32.Visibility = Visibility.Visible;
            B32.Background = new SolidColorBrush(Colors.White);

            P42.IsEnabled = true;
            P42.Visibility = Visibility.Visible;
            B42.Background = new SolidColorBrush(Colors.White);

            P52.IsEnabled = true;
            P52.Visibility = Visibility.Visible;
            B52.Background = new SolidColorBrush(Colors.White);

            P13.IsEnabled = true;
            P13.Visibility = Visibility.Visible;
            B13.Background = new SolidColorBrush(Colors.White);

            P23.IsEnabled = true;
            P23.Visibility = Visibility.Visible;
            B23.Background = new SolidColorBrush(Colors.White);

            P33.IsEnabled = true;
            P33.Visibility = Visibility.Visible;
            B33.Background = new SolidColorBrush(Colors.White);

            P43.IsEnabled = true;
            P43.Visibility = Visibility.Visible;
            B43.Background = new SolidColorBrush(Colors.White);

            P53.IsEnabled = true;
            P53.Visibility = Visibility.Visible;
            B53.Background = new SolidColorBrush(Colors.White);

            P14.IsEnabled = true;
            P14.Visibility = Visibility.Visible;
            B14.Background = new SolidColorBrush(Colors.White);

            P24.IsEnabled = true;
            P24.Visibility = Visibility.Visible;
            B24.Background = new SolidColorBrush(Colors.White);

            P34.IsEnabled = true;
            P34.Visibility = Visibility.Visible;
            B34.Background = new SolidColorBrush(Colors.White);

            P44.IsEnabled = true;
            P44.Visibility = Visibility.Visible;
            B44.Background = new SolidColorBrush(Colors.White);

            P54.IsEnabled = true;
            P54.Visibility = Visibility.Visible;
            B54.Background = new SolidColorBrush(Colors.White);





            P11.Background = new SolidColorBrush(Colors.Green);
            P21.Background = new SolidColorBrush(Colors.Green);
            P31.Background = new SolidColorBrush(Colors.Green);
            P41.Background = new SolidColorBrush(Colors.Green);
            P51.Background = new SolidColorBrush(Colors.Green);
            P12.Background = new SolidColorBrush(Colors.Green);
            P22.Background = new SolidColorBrush(Colors.Green);
            P32.Background = new SolidColorBrush(Colors.Green);
            P42.Background = new SolidColorBrush(Colors.Green);
            P52.Background = new SolidColorBrush(Colors.Green);
            P13.Background = new SolidColorBrush(Colors.Green);
            P23.Background = new SolidColorBrush(Colors.Green);
            P33.Background = new SolidColorBrush(Colors.Green);
            P43.Background = new SolidColorBrush(Colors.Green);
            P53.Background = new SolidColorBrush(Colors.Green);
            P14.Background = new SolidColorBrush(Colors.Green);
            P24.Background = new SolidColorBrush(Colors.Green);
            P34.Background = new SolidColorBrush(Colors.Green);
            P44.Background = new SolidColorBrush(Colors.Green);
            P54.Background = new SolidColorBrush(Colors.Green);
        }
        // Book from Free Court
        private void Book_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            UCBooking bookNow = new UCBooking();
            bookNow.lblCustName.Content = CurrUserLbl.Content;
            bookNow.lblCustLeft.Content = CurrUserLbl.Content;
            bookNow.lblIDnum.Content = lblUserIdHidden.Content;
            bookNow.custImage.Source = CurrUserImg.Source;



            Button targetButton = (sender as Button);


            if (targetButton != null && targetButton.Name == "P11")
            {

                bookNow.comboCourt.SelectedIndex = 0;
                if (cldSample.SelectedDate != null)
                {
                    gridTotal.Children.Add(bookNow);
                    bookNow.comboSession.SelectedIndex = 0;
                    bookNow.dpDate.SelectedDate = cldSample.SelectedDate;

                }
                else
                {
                    MessageBox.Show("You should select a date first.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return;
                }

            }

            if (targetButton != null && targetButton.Name == "P21")
            {

                bookNow.comboCourt.SelectedIndex = 0;
                if (cldSample.SelectedDate != null)
                {
                    gridTotal.Children.Add(bookNow);
                    bookNow.comboSession.SelectedIndex = 1;
                    bookNow.dpDate.SelectedDate = cldSample.SelectedDate;

                }
                else
                {
                    MessageBox.Show("You should select a date first.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return;
                }

            }
            if (targetButton != null && targetButton.Name == "P31")
            {

                bookNow.comboCourt.SelectedIndex = 0;
                if (cldSample.SelectedDate != null)
                {
                    gridTotal.Children.Add(bookNow);
                    bookNow.comboSession.SelectedIndex = 2;
                    bookNow.dpDate.SelectedDate = cldSample.SelectedDate;

                }
                else
                {
                    MessageBox.Show("You should select a date first.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return;
                }

            }
            if (targetButton != null && targetButton.Name == "P41")
            {

                bookNow.comboCourt.SelectedIndex = 0;
                if (cldSample.SelectedDate != null)
                {
                    gridTotal.Children.Add(bookNow);
                    bookNow.comboSession.SelectedIndex = 3;
                    bookNow.dpDate.SelectedDate = cldSample.SelectedDate;

                }
                else
                {
                    MessageBox.Show("You should select a date first.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return;
                }

            }
            if (targetButton != null && targetButton.Name == "P51")
            {

                bookNow.comboCourt.SelectedIndex = 0;
                if (cldSample.SelectedDate != null)
                {
                    gridTotal.Children.Add(bookNow);
                    bookNow.comboSession.SelectedIndex = 4;
                    bookNow.dpDate.SelectedDate = cldSample.SelectedDate;

                }
                else
                {
                    MessageBox.Show("You should select a date first.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return;
                }

            }
            if (targetButton != null && targetButton.Name == "P12")
            {

                bookNow.comboCourt.SelectedIndex = 1;
                if (cldSample.SelectedDate != null)
                {
                    gridTotal.Children.Add(bookNow);
                    bookNow.comboSession.SelectedIndex = 0;
                    bookNow.dpDate.SelectedDate = cldSample.SelectedDate;

                }
                else
                {
                    MessageBox.Show("You should select a date first.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return;
                }

            }
            if (targetButton != null && targetButton.Name == "P22")
            {

                bookNow.comboCourt.SelectedIndex = 1;
                if (cldSample.SelectedDate != null)
                {
                    gridTotal.Children.Add(bookNow);
                    bookNow.comboSession.SelectedIndex = 1;
                    bookNow.dpDate.SelectedDate = cldSample.SelectedDate;

                }
                else
                {
                    MessageBox.Show("You should select a date first.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return;
                }

            }
            if (targetButton != null && targetButton.Name == "P32")
            {

                bookNow.comboCourt.SelectedIndex = 1;
                if (cldSample.SelectedDate != null)
                {
                    gridTotal.Children.Add(bookNow);
                    bookNow.comboSession.SelectedIndex = 2;
                    bookNow.dpDate.SelectedDate = cldSample.SelectedDate;

                }
                else
                {
                    MessageBox.Show("You should select a date first.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return;
                }

            }
            if (targetButton != null && targetButton.Name == "P42")
            {

                bookNow.comboCourt.SelectedIndex = 1;
                if (cldSample.SelectedDate != null)
                {
                    gridTotal.Children.Add(bookNow);
                    bookNow.comboSession.SelectedIndex = 3;
                    bookNow.dpDate.SelectedDate = cldSample.SelectedDate;

                }
                else
                {
                    MessageBox.Show("You should select a date first.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return;
                }

            }
            if (targetButton != null && targetButton.Name == "P52")
            {

                bookNow.comboCourt.SelectedIndex = 1;
                if (cldSample.SelectedDate != null)
                {
                    gridTotal.Children.Add(bookNow);
                    bookNow.comboSession.SelectedIndex = 4;
                    bookNow.dpDate.SelectedDate = cldSample.SelectedDate;

                }
                else
                {
                    MessageBox.Show("You should select a date first.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return;
                }

            }
            if (targetButton != null && targetButton.Name == "P13")
            {

                bookNow.comboCourt.SelectedIndex = 2;
                if (cldSample.SelectedDate != null)
                {
                    gridTotal.Children.Add(bookNow);
                    bookNow.comboSession.SelectedIndex = 0;
                    bookNow.dpDate.SelectedDate = cldSample.SelectedDate;

                }
                else
                {
                    MessageBox.Show("You should select a date first.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return;
                }

            }
            if (targetButton != null && targetButton.Name == "P23")
            {

                bookNow.comboCourt.SelectedIndex = 2;
                if (cldSample.SelectedDate != null)
                {
                    gridTotal.Children.Add(bookNow);
                    bookNow.comboSession.SelectedIndex = 1;
                    bookNow.dpDate.SelectedDate = cldSample.SelectedDate;

                }
                else
                {
                    MessageBox.Show("You should select a date first.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return;
                }

            }
            if (targetButton != null && targetButton.Name == "P33")
            {

                bookNow.comboCourt.SelectedIndex = 2;
                if (cldSample.SelectedDate != null)
                {
                    gridTotal.Children.Add(bookNow);
                    bookNow.comboSession.SelectedIndex = 2;
                    bookNow.dpDate.SelectedDate = cldSample.SelectedDate;

                }
                else
                {
                    MessageBox.Show("You should select a date first.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return;
                }

            }
            if (targetButton != null && targetButton.Name == "P43")
            {

                bookNow.comboCourt.SelectedIndex = 2;
                if (cldSample.SelectedDate != null)
                {
                    gridTotal.Children.Add(bookNow);
                    bookNow.comboSession.SelectedIndex = 3;
                    bookNow.dpDate.SelectedDate = cldSample.SelectedDate;

                }
                else
                {
                    MessageBox.Show("You should select a date first.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return;
                }

            }
            if (targetButton != null && targetButton.Name == "P53")
            {

                bookNow.comboCourt.SelectedIndex = 2;
                if (cldSample.SelectedDate != null)
                {
                    gridTotal.Children.Add(bookNow);
                    bookNow.comboSession.SelectedIndex = 4;
                    bookNow.dpDate.SelectedDate = cldSample.SelectedDate;

                }
                else
                {
                    MessageBox.Show("You should select a date first.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return;
                }

            }
            if (targetButton != null && targetButton.Name == "P14")
            {

                bookNow.comboCourt.SelectedIndex = 3;
                if (cldSample.SelectedDate != null)
                {
                    gridTotal.Children.Add(bookNow);
                    bookNow.comboSession.SelectedIndex = 0;
                    bookNow.dpDate.SelectedDate = cldSample.SelectedDate;

                }
                else
                {
                    MessageBox.Show("You should select a date first.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return;
                }

            }
            if (targetButton != null && targetButton.Name == "P24")
            {

                bookNow.comboCourt.SelectedIndex = 3;
                if (cldSample.SelectedDate != null)
                {
                    gridTotal.Children.Add(bookNow);
                    bookNow.comboSession.SelectedIndex = 1;
                    bookNow.dpDate.SelectedDate = cldSample.SelectedDate;

                }
                else
                {
                    MessageBox.Show("You should select a date first.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return;
                }

            }
            if (targetButton != null && targetButton.Name == "P34")
            {

                bookNow.comboCourt.SelectedIndex = 3;
                if (cldSample.SelectedDate != null)
                {
                    gridTotal.Children.Add(bookNow);
                    bookNow.comboSession.SelectedIndex = 2;
                    bookNow.dpDate.SelectedDate = cldSample.SelectedDate;

                }
                else
                {
                    MessageBox.Show("You should select a date first.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return;
                }

            }

            if (targetButton != null && targetButton.Name == "P44")
            {

                bookNow.comboCourt.SelectedIndex = 3;
                if (cldSample.SelectedDate != null)
                {
                    gridTotal.Children.Add(bookNow);
                    bookNow.comboSession.SelectedIndex = 3;
                    bookNow.dpDate.SelectedDate = cldSample.SelectedDate;

                }
                else
                {
                    MessageBox.Show("You should select a date first.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return;
                }

            }
            if (targetButton != null && targetButton.Name == "P54")
            {

                bookNow.comboCourt.SelectedIndex = 3;
                if (cldSample.SelectedDate != null)
                {
                    gridTotal.Children.Add(bookNow);
                    bookNow.comboSession.SelectedIndex = 4;
                    bookNow.dpDate.SelectedDate = cldSample.SelectedDate;

                }
                else
                {
                    MessageBox.Show("You should select a date first.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return;
                }

            }
        }

        private void logOut_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            WelcomePage welcome = new WelcomePage();
            welcome.Show();
        }



    }
}
