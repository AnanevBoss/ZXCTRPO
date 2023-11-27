using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
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
using TableTapManager.Model;


namespace TableTapManager
{
    /// <summary>
    /// Логика взаимодействия для InfoBok.xaml
    /// </summary>
    public partial class InfoBok : Window
    {
        public InfoBok()
        {
            InitializeComponent();
            DgridBooking.ItemsSource = TableTapEntities3.GetContext().Booking.ToList();
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;

        }

        private void BtnAdd(object sender, RoutedEventArgs e)
        {
            Add add = new Add();
            add.Show();
            this.Close();
        }

        private void BtnEdit(object sender, RoutedEventArgs e)
        {
            Editing edi = new Editing((sender as Button).DataContext as Booking);
            edi.Show();
            this.Close(); ;
        }

        private void BtnDell(object sender, RoutedEventArgs e)
        {
            var productsForRemoving = DgridBooking.SelectedItems.Cast<Booking>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {productsForRemoving.Count} элементов?",
                "Внимание",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) != MessageBoxResult.Yes)
            {
                return;
            }

            try
            {
                var context = TableTapEntities3.GetContext();

                context.Booking.RemoveRange(productsForRemoving);
                context.SaveChanges();

                MessageBox.Show("Данные удалены");

                DgridBooking.ItemsSource = context.Booking.ToList();
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                if (ex.InnerException != null)
                {
                    message += $": {ex.InnerException.Message}";
                }

                MessageBox.Show(message);
            }
        }

        private void BtnSearch(object sender, RoutedEventArgs e)
        {
            string searchValue = TxtSearch.Text;
            int searchIntValue;

            if (IsInputValid(searchValue, out searchIntValue))
            {
                DgridBooking.ItemsSource = GetFilteredBookings(searchIntValue);
            }
        }

        private bool IsInputValid(string inputValue, out int integerOutput)
        {
            if (!int.TryParse(inputValue, out integerOutput))
            {
                MessageBox.Show("Введите что нибудь");
                return false;
            }

            return true;
        }

        private List<Booking> GetFilteredBookings(int guestsNumber)
        {
            return TableTapEntities3.GetContext().Booking.Where(b => b.Number_of_guests == guestsNumber).ToList();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Booking> currentBookings = TableTapEntities3.GetContext().Booking.ToList();

            var filteredBookings = currentBookings.Select(b => new Booking
            {
                Booking_time = b.Booking_time
            }).ToList();
            DgridBooking.ItemsSource = filteredBookings;
        }

        private void CSV(object sender, RoutedEventArgs e)
        {
            CSV csv = new CSV();
            csv.Show();
            this.Close();
        }

    }
}

    


