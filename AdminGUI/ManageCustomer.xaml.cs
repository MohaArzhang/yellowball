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
using CustomerGUI;


namespace AdminGUI
{
    /// <summary>
    /// Interaction logic for ManageCustomer.xaml
    /// </summary>
    public partial class ManageCustomer : UserControl
    {
        FinalProjectWPFEntitiesApril18 ctx;
        int customerID = 0;
        public object CustomerGUI { get; private set; }

        public ManageCustomer()
        {
            try
            {
                InitializeComponent();
                ctx = new FinalProjectWPFEntitiesApril18();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message, "Database operation failed.", MessageBoxButton.OK, MessageBoxImage.Error);
                Environment.Exit(1);
            }
        }

        private void btnName_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbID.Text = "";
            btnEdit.IsEnabled = false;
            btnDelete.IsEnabled = false;
        }

        private void tbID_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbName.Text = "";
            btnEdit.IsEnabled = false;
            btnDelete.IsEnabled = false;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (tbName.Text != "")
            {
                try
                {
                    List<Customer> customer = (from c in ctx.Customers where c.Name == tbName.Text select c).ToList<Customer>();  // exception
                    lvCustomer.ItemsSource = customer;
                    if (customer.Count == 0)
                    {
                        tbName.Text = "";
                        MessageBox.Show("No record found.", "Record Fail", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        return;
                    }
                }
                catch (SystemException ex)
                {
                    tbID.Text = "";
                    MessageBox.Show("Database Error!:\n" + ex.Message, "Database Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            if (tbID.Text != "")
            {
                try
                {
                    int customerID = Convert.ToInt32(tbID.Text);
                    List<Customer> customer = (from c in ctx.Customers where c.CustId == customerID select c).ToList<Customer>();        // exception
                    lvCustomer.ItemsSource = customer;
                    if (customer.Count == 0)
                    {
                        MessageBox.Show("No record found.", "Record Fail", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        return;
                    }
                }
                catch (SystemException ex)
                {
                    MessageBox.Show("Database Error!:\n" + ex.Message, "Database Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }

            Utility.AutoResizeColumns(lvCustomer);
        }

        private void lvCustomer_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Customer customer = lvCustomer.SelectedItem as Customer;
            if (customer == null)
            {
                return;
            }
            CustomerManagerDLG dlg = new CustomerManagerDLG(customer);
            dlg.ParentWindow = this;
            dlg.btnUpdate.Visibility = Visibility.Visible;
            dlg.dpBirth.SelectedDate = customer.DOB;
            dlg.Show();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = lvCustomer.SelectedItem as Customer;
            CustomerManagerDLG dlg = new CustomerManagerDLG(customer);
            dlg.ParentWindow = this;
            dlg.btnUpdate.Visibility = Visibility.Visible;
            dlg.dpBirth.SelectedDate = customer.DOB;
            dlg.Show();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Customer currentCust = (Customer)lvCustomer.SelectedItem;
            try
            {
                MessageBoxResult result = MessageBox.Show("Are you Sure You want Delete?", "Session Remove", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);

                if (result == MessageBoxResult.Yes)
                {
                    ctx.Customers.Remove(currentCust);
                    ctx.SaveChanges();
                    lvCustomer.ClearValue(ListView.ItemsSourceProperty);
                    tbID.Text = "";
                    tbName.Text = "";
                }
                else return;
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message, "Database operation failed", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            gridTotal.Visibility = Visibility.Hidden;
        }

        private void btnAddCust_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer();
            CustomerManagerDLG dlg = new CustomerManagerDLG(customer);
            dlg.ParentWindow = this;
            dlg.Show();
        }


        private void lvCustomer_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (lvCustomer.SelectedItem == null)
            {
                return;
            }
            else
            {
                btnDelete.IsEnabled = true;
                btnEdit.IsEnabled = true;
            }
        }
    }
}
