using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace Szepsegek.Pages
{
    /// <summary>
    /// Interaction logic for FoglalasPage.xaml
    /// </summary>
    public partial class FoglalasPage : Page
    {
        public FoglalasPage()
        {
            string connectionString = "Server=localhost;Database=szepsegek;User ID=root;Password=;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM dolgozók";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
            }
        }

        private void DatePickerSelectedDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DatePickerSelectedDate.SelectedDate.HasValue)
            {
                DateTime selectedDate = DatePickerSelectedDate.SelectedDate.Value;
                TextBlockSelectedDate.Text = $"Kiválasztott dátum: {selectedDate.ToShortDateString()}";
            }
            else
            {
                TextBlockSelectedDate.Text = "Nincs dátum kiválasztva.";
            }

        }
        private void Foglalas_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    
}       

        

