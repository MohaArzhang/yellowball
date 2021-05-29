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

namespace AdminGUI
{
    /// <summary>
    /// Interaction logic for ManageCourtUC.xaml
    /// </summary>
    public partial class ManageCourtUC : UserControl
    {
        FinalProjectWPFEntitiesApril18 ctx;
        public ManageCourtUC()
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

        private void cldSample_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            P11.Content = "";
            P12.Content = "";
            P13.Content = "";
            P14.Content = "";
            P21.Content = "";
            P22.Content = "";
            P23.Content = "";
            P24.Content = "";
            P31.Content = "";
            P32.Content = "";
            P33.Content = "";
            P34.Content = "";
            P41.Content = "";
            P42.Content = "";
            P43.Content = "";
            P44.Content = "";
            P51.Content = "";
            P52.Content = "";
            P53.Content = "";
            P54.Content = "";
            // first row
            DateTime selectedDate = cldSample.SelectedDate.Value;

            var selection1 = ctx.Bookings.Where(b => b.Date == selectedDate && b.CourtId == 1 && b.SessionTime == "10:00 AM").ToList();
            foreach (var item in selection1)
            {
                P11.Content = item.Customer.Name;
            }
            var selection2 = ctx.Bookings.Where(b => b.Date == selectedDate && b.CourtId == 2 && b.SessionTime == "10:00 AM").ToList();
            foreach (var item in selection2)
            {
                P12.Content = item.Customer.Name;
            }
            var selection3 = ctx.Bookings.Where(b => b.Date == selectedDate && b.CourtId == 3 && b.SessionTime == "10:00 AM").ToList();
            foreach (var item in selection3)
            {
                P13.Content = item.Customer.Name;
            }
            var selection4 = ctx.Bookings.Where(b => b.Date == selectedDate && b.CourtId == 4 && b.SessionTime == "10:00 AM").ToList();
            foreach (var item in selection4)
            {
                P14.Content = item.Customer.Name;
            }

            // second row

            var selection5 = ctx.Bookings.Where(b => b.Date == selectedDate && b.CourtId == 1 && b.SessionTime == "12:00 PM").ToList();
            foreach (var item in selection5)
            {
                P21.Content = item.Customer.Name;
            }
            var selection6 = ctx.Bookings.Where(b => b.Date == selectedDate && b.CourtId == 2 && b.SessionTime == "12:00 PM").ToList();
            foreach (var item in selection6)
            {
                P22.Content = item.Customer.Name;
            }
            var selection7 = ctx.Bookings.Where(b => b.Date == selectedDate && b.CourtId == 3 && b.SessionTime == "12:00 PM").ToList();
            foreach (var item in selection7)
            {
                P23.Content = item.Customer.Name;
            }
            var selection8 = ctx.Bookings.Where(b => b.Date == selectedDate && b.CourtId == 4 && b.SessionTime == "12:00 PM").ToList();
            foreach (var item in selection8)
            {
                P24.Content = item.Customer.Name;
            }

            // third row
            var selection9 = ctx.Bookings.Where(b => b.Date == selectedDate && b.CourtId == 1 && b.SessionTime == "2:00 PM").ToList();
            foreach (var item in selection9)
            {
                P31.Content = item.Customer.Name;
            }
            var selection10 = ctx.Bookings.Where(b => b.Date == selectedDate && b.CourtId == 2 && b.SessionTime == "2:00 PM").ToList();
            foreach (var item in selection10)
            {
                P32.Content = item.Customer.Name;
            }
            var selection11 = ctx.Bookings.Where(b => b.Date == selectedDate && b.CourtId == 3 && b.SessionTime == "2:00 PM").ToList();
            foreach (var item in selection11)
            {
                P33.Content = item.Customer.Name;
            }
            var selection12 = ctx.Bookings.Where(b => b.Date == selectedDate && b.CourtId == 4 && b.SessionTime == "2:00 PM").ToList();
            foreach (var item in selection12)
            {
                P34.Content = item.Customer.Name;
            }

            // forth row
            var selection13 = ctx.Bookings.Where(b => b.Date == selectedDate && b.CourtId == 1 && b.SessionTime == "4:00 PM").ToList();
            foreach (var item in selection13)
            {
                P41.Content = item.Customer.Name;
            }
            var selection14 = ctx.Bookings.Where(b => b.Date == selectedDate && b.CourtId == 2 && b.SessionTime == "4:00 PM").ToList();
            foreach (var item in selection14)
            {
                P42.Content = item.Customer.Name;
            }
            var selection15 = ctx.Bookings.Where(b => b.Date == selectedDate && b.CourtId == 3 && b.SessionTime == "4:00 PM").ToList();
            foreach (var item in selection15)
            {
                P43.Content = item.Customer.Name;
            }
            var selection16 = ctx.Bookings.Where(b => b.Date == selectedDate && b.CourtId == 4 && b.SessionTime == "4:00 PM").ToList();
            foreach (var item in selection16)
            {
                P44.Content = item.Customer.Name;
            }

            // fifth row
            var selection17 = ctx.Bookings.Where(b => b.Date == selectedDate && b.CourtId == 1 && b.SessionTime == "6:00 PM").ToList();
            foreach (var item in selection17)
            {
                P51.Content = item.Customer.Name;
            }
            var selection18 = ctx.Bookings.Where(b => b.Date == selectedDate && b.CourtId == 2 && b.SessionTime == "6:00 PM").ToList();
            foreach (var item in selection18)
            {
                P52.Content = item.Customer.Name;
            }
            var selection19 = ctx.Bookings.Where(b => b.Date == selectedDate && b.CourtId == 3 && b.SessionTime == "6:00 PM").ToList();
            foreach (var item in selection19)
            {
                P53.Content = item.Customer.Name;
            }
            var selection20 = ctx.Bookings.Where(b => b.Date == selectedDate && b.CourtId == 4 && b.SessionTime == "6:00 PM").ToList();
            foreach (var item in selection20)
            {
                P54.Content = item.Customer.Name;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            gridCourt.Visibility = Visibility.Hidden;
        }

        private void cldSample_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            DateTime selectedDate = cldSample.SelectedDate.Value;
            var selection = ctx.Bookings.Where(b => b.Date == selectedDate && b.CourtId == 1 && b.SessionTime == "10:00 AM");
            foreach (var item in selection)
            {
                P11.Content = item.Customer.Name;
            }
        }

        private void btnCourt_Click(object sender, RoutedEventArgs e)
        {
            CourtDLG dlg = new CourtDLG();
            dlg.Show();
        }
    }
}
