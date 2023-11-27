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
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        public Add()
        {
            InitializeComponent();
            Id.ItemsSource = TableTapEntities3.GetContext().Booking_status.ToList();
            Id2.ItemsSource = TableTapEntities3.GetContext().Table.ToList();
            Id3.ItemsSource = TableTapEntities3.GetContext().User.ToList();
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
        }
        private void BtnAdd(object sender, RoutedEventArgs e)
        {
            try
            {
                DataBaseClass dataClass = new DataBaseClass();
                dataClass.sqlExecute($"insert into [dbo].[Booking] ([Booking_status_id],[Table_id],[User_id], [Booking_date], [Booking_time], [Number_of_guests]) values  ({Id.SelectedValue}, {Id2.SelectedValue}, {Id3.SelectedValue},'{Booking_date.Text}', '{Booking_time.Text}', '{Number_of_guests.Text}')", DataBaseClass.act.manipulation);
                MessageBox.Show("Успешное добавление");
            }

         catch
            {
                MessageBox.Show("Ошибка");
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
