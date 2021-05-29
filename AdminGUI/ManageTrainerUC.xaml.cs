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
    /// Interaction logic for ManageTrainerUC.xaml
    /// </summary>
    public partial class ManageTrainerUC : UserControl
    {
        FinalProjectWPFEntitiesApril18 ctx;
        int customerID = 0;
        public ManageTrainerUC()
        {
            InitializeComponent();
            ctx = new FinalProjectWPFEntitiesApril18();
        }
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (tbName.Text != "")
            {
                try
                {
                    List<Trainer> trainer = (from c in ctx.Trainers where c.Name == tbName.Text select c).ToList<Trainer>();  // exception
                    lvTrainer.ItemsSource = trainer;
                    if (trainer.Count == 0)
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
                    int trainerID = Convert.ToInt32(tbID.Text);
                    List<Trainer> trainer = (from c in ctx.Trainers where c.TrainerId == trainerID select c).ToList<Trainer>();        // exception
                    lvTrainer.ItemsSource = trainer;
                    if (trainer.Count == 0)
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

            Utility.AutoResizeColumns(lvTrainer);
        }

        private void tbID_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbName.Text = "";
            btnEdit.IsEnabled = false;
            btnDelete.IsEnabled = false;
        }

        private void tbName_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbID.Text = "";
            btnEdit.IsEnabled = false;
            btnDelete.IsEnabled = false;
        }

        private void btnAddTrainer_Click(object sender, RoutedEventArgs e)
        {
            Trainer trainer = new Trainer();
            AddTrainerDLG dlg = new AddTrainerDLG(trainer);
            dlg.Show();
        }

        private void lvTrainer_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Trainer trainer = lvTrainer.SelectedItem as Trainer;
            if (trainer == null)
            {
                return;
            }

            AddTrainerDLG dlg = new AddTrainerDLG(trainer);
            dlg.ParentWindow = this;
            dlg.btnAdd.Visibility = Visibility.Hidden;
            dlg.btnUpdate.Visibility = Visibility.Visible;
            dlg.tbAddTitle.Visibility = Visibility.Hidden;
            dlg.tbManageTitle.Visibility = Visibility.Visible;
            dlg.Show();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Trainer trainer = lvTrainer.SelectedItem as Trainer;
            if (trainer == null)
            {
                return;
            }
            AddTrainerDLG dlg = new AddTrainerDLG(trainer);
            dlg.ParentWindow = this;
            dlg.btnAdd.Visibility = Visibility.Hidden;
            dlg.btnUpdate.Visibility = Visibility.Visible;
            dlg.tbAddTitle.Visibility = Visibility.Hidden;
            dlg.tbManageTitle.Visibility = Visibility.Visible;
            dlg.Show();
        }

        private void lvTrainer_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (lvTrainer.SelectedItem == null)
            {
                return;
            }
            else
            {
                btnDelete.IsEnabled = true;
                btnEdit.IsEnabled = true;
            }
        }


        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            gridTotal.Visibility = Visibility.Hidden;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Trainer currentTrain = (Trainer)lvTrainer.SelectedItem;
            try
            {
                MessageBoxResult result = MessageBox.Show("Are you Sure You want Delete?", "Session Remove", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);

                if (result == MessageBoxResult.Yes)
                {
                    ctx.Trainers.Remove(currentTrain);
                    ctx.SaveChanges();
                    lvTrainer.ClearValue(ListView.ItemsSourceProperty);
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
    }
}
