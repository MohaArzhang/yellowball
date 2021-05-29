using LibraryYellowBall;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AdminGUI
{
    /// <summary>
    /// Interaction logic for Report1UC.xaml
    /// </summary>
    public partial class Report1UC : UserControl
    {
        FinalProjectWPFEntitiesApril18 ctx;
        private List<object> myCollection;
        private List<object> myCollectionForPie;
        private List<object> myCollectionForArea;

        public Report1UC()
        {
            try
            {
                InitializeComponent();
                ctx = new FinalProjectWPFEntitiesApril18();
            }
            catch (SystemException ex)
            {

                MessageBox.Show(ex.Message, "Database Operation Failed.", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }




        //code for column Chart
        private void myChartLoad()
        {
            myCollection = new List<object>();

            var query = from c in ctx.Bookings
                        from x in ctx.Courts
                        where c.CourtId == x.CourtId
                        group c by x.CourtId
                        into g
                        select new { CourtName = g.Key, Revenue = g.Sum(x => x.PayAmount) };



            foreach (var item in query)
            {

                myCollection.Add(item);
            }
                ((ColumnSeries)ColumnChart.Series[0]).ItemsSource = myCollection;
        }
        
        //Pie chart
        private void PieChartLoad()
        {
            myCollectionForPie = new List<object>();

            var queryPie = from d in ctx.Bookings
                           from y in ctx.Courts
                           where d.CourtId == y.CourtId
                           group d by y.CourtId
                        into g
                           select new { CourtName_Pie = g.Key, Revenue_Pie = g.Sum(x => x.PayAmount) };



            foreach (var item in queryPie)
            {

                myCollectionForPie.Add(item);
            }
                ((PieSeries)PieChart.Series[0]).ItemsSource = myCollectionForPie;
        }

        //code for Area Chart
        private void AreaChartLoad()
        {
            myCollectionForArea = new List<object>();

            var queryArea = from f in ctx.Bookings
                            from z in ctx.Courts
                            where f.CourtId == z.CourtId
                            group f by z.CourtId
                        into g
                            select new { CourtName_Area = g.Key, Revenue_Area = g.Sum(x => x.PayAmount) };



            foreach (var item in queryArea)
            {

                myCollectionForArea.Add(item);
            }
             ((AreaSeries)AreaChart.Series[0]).ItemsSource = myCollectionForArea;
        }
        
        //BTNs

        private void btn_First(object sender, RoutedEventArgs e)
        {
            
            PieChart.Visibility = Visibility.Visible;
            PieChartLoad();
            ColumnChart.Visibility = Visibility.Hidden;
            AreaChart.Visibility = Visibility.Hidden;
        }
        private void btn_second(object sender, RoutedEventArgs e)
        {
           

            ColumnChart.Visibility = Visibility.Visible;
            myChartLoad();
            PieChart.Visibility = Visibility.Hidden;
            AreaChart.Visibility = Visibility.Hidden;
        }
        private void btn_third(object sender, RoutedEventArgs e)
        {
            
            AreaChart.Visibility = Visibility.Visible;
            AreaChartLoad();
            ColumnChart.Visibility = Visibility.Hidden;
            PieChart.Visibility = Visibility.Hidden;
        }

        private void gridMain_Loaded(object sender, RoutedEventArgs e)
        {
            PieChartLoad();
        }

        private void BbtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
    }
}
