using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using TableTapManager.Model;

namespace TableTapManager
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;

        }

        private void SingIn(object sender, RoutedEventArgs e)
        {
            DataBaseClass dataClass = new DataBaseClass();
            string sql = "select [Login], [Password] from [dbo].[Manager]";
            SqlCommand cmd = new SqlCommand(sql, dataClass.connection);
            dataClass.connection.Open();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (Login.Text == reader["Login"].ToString() && Password.Text == reader["Password"].ToString())
                    {
                        InfoBok inf = new InfoBok();
                        inf.Show();
                        this.Close();
                        MessageBox.Show("Вы успешно зашли");
                    }
                }

            }

            dataClass.connection.Close();
        }




    }
    }

