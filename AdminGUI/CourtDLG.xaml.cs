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

namespace AdminGUI
{
    /// <summary>
    /// Interaction logic for CourtDLG.xaml
    /// </summary>
    public partial class CourtDLG : Window
    {
        FinalProjectWPFEntitiesApril18 ctx;
        public CourtDLG()
        {
            try
            {
                InitializeComponent();
                ctx = new FinalProjectWPFEntitiesApril18();     // exception
            }
            catch (SystemException ex)
            {

                MessageBox.Show(ex.Message, "Database Operation Failed ", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            bool courtCheck1 = ctx.Courts.Any(c => c.CourtId == 1 && c.Available == true);
            bool courtCheck2 = ctx.Courts.Any(c => c.CourtId == 2 && c.Available == true);
            bool courtCheck3 = ctx.Courts.Any(c => c.CourtId == 3 && c.Available == true);
            bool courtCheck4 = ctx.Courts.Any(c => c.CourtId == 4 && c.Available == true);
            if (courtCheck1 == true)
            {
                radio1Avail.IsChecked = true;
            }
            else
            {
                radio1Un.IsChecked = true;
            }
            if (courtCheck2 == true)
            {
                radio2Avail.IsChecked = true;
            }
            else
            {
                radio2Un.IsChecked = true;
            }
            if (courtCheck3 == true)
            {
                radio3Avail.IsChecked = true;
            }
            else
            {
                radio3Un.IsChecked = true;
            }
            if (courtCheck4 == true)
            {
                radio4Avail.IsChecked = true;
            }
            else
            {
                radio4Un.IsChecked = true;
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var courtRow1 = ctx.Courts.Where(c => c.CourtId == 1).FirstOrDefault();    // exception
                if (radio1Un.IsChecked == true)
                {
                    courtRow1.Available = false;
                }
                else { courtRow1.Available = true; }

                var courtRow2 = ctx.Courts.Where(c => c.CourtId == 2).FirstOrDefault();    // exception
                if (radio2Un.IsChecked == true)
                {
                    courtRow2.Available = false;
                }
                else { courtRow2.Available = true; }

                var courtRow3 = ctx.Courts.Where(c => c.CourtId == 3).FirstOrDefault();    // exception
                if (radio3Un.IsChecked == true)
                {
                    courtRow3.Available = false;
                }
                else { courtRow3.Available = true; }

                var courtRow4 = ctx.Courts.Where(c => c.CourtId == 4).FirstOrDefault();    // exception
                if (radio4Un.IsChecked == true)
                {
                    courtRow4.Available = false;
                }
                else { courtRow4.Available = true; }
                ctx.SaveChanges();
                MessageBox.Show("Datase updated successfully.", "Database Message", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message, "Database Operation Failed ", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
    }
}
