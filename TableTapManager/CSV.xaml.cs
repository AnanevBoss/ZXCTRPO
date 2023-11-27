using CsvHelper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Globalization;
using System.IO;
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
    /// Логика взаимодействия для CSV.xaml
    /// </summary>
    public partial class CSV : Window
    {
        public CSV()
        {
            InitializeComponent();
            DgridBooking.ItemsSource = TableTapEntities3.GetContext().Booking.ToList();
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
        }
        private void BtnExportToCSV(object sender, RoutedEventArgs e)
        {
            List<Booking> bookings = DgridBooking.ItemsSource.Cast<Booking>().ToList();
            ExportToCSV(bookings);
        }

       
        private void ExportToCSV(List<Booking> bookings)
        {
            var csvPath = "path_to_csv_file.csv";

            using (var writer = new StreamWriter(csvPath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(bookings);
            }

            MessageBox.Show("Данные экспортированы в CSV файл");
        }

        private void BtnBack(object sender, RoutedEventArgs e)
        {
            InfoBok inf = new InfoBok();
            inf.Show();
            this.Close();
        }
    }
    }





        
            
    
