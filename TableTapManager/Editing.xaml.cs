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
using TableTapManager.Model;

namespace TableTapManager
{
    /// <summary>
    /// Логика взаимодействия для Editing.xaml
    /// </summary>
    public partial class Editing : Window
    {
        public TableTapEntities3 baseModel = new TableTapEntities3();
        public Editing(Booking selectProduct)

        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
            Id.ItemsSource = TableTapEntities3.GetContext().Booking_status.ToList();
            Id2.ItemsSource = TableTapEntities3.GetContext().Table.ToList();
            Id3.ItemsSource = TableTapEntities3.GetContext().User.ToList();
            getBooking();
        }

        public void getBooking()
        {

            DgridBooking.ItemsSource = null;
            DgridBooking.ItemsSource = baseModel.Booking.ToList();
        }

        private void BtnEdit(object sender, RoutedEventArgs e)
        {
            
            Booking selectedProduct = DgridBooking.SelectedItem as Booking;

            if (selectedProduct != null)
            {
                
                string newValue1 = Booking_date.Text;
                string newValue2 = Booking_time.Text;
                string newValue3 = Number_of_guests.Text;
                string newValue4 = Id.SelectedValue.ToString();
                string newValue5 = Id2.SelectedValue.ToString();
                string newValue6 = Id3.SelectedValue.ToString();


                
                selectedProduct.Booking_date = DateTime.Parse(newValue1);
                selectedProduct.Booking_time = TimeSpan.Parse(newValue2);
                selectedProduct.Number_of_guests = int.Parse(newValue3);
                selectedProduct.Booking_status_id = int.Parse(newValue4);
                selectedProduct.Table_id = int.Parse(newValue5);
                selectedProduct.User_id = int.Parse(newValue6);
                



                
                try
                {
                    TableTapEntities3.GetContext().SaveChanges();
                    MessageBox.Show("Данные обновлены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

                
                DgridBooking.ItemsSource = null;
                DgridBooking.ItemsSource = TableTapEntities3.GetContext().Booking.ToList();
            }
            else
            {
                MessageBox.Show("Выберите элемент для редактирования.");
            }
        }

        private void BtnBack(object sender, RoutedEventArgs e)
        {
            InfoBok inf = new InfoBok();
            inf.Show();
            this.Close();
        }
    }
}
