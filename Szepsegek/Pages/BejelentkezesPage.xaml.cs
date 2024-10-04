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

namespace Szepsegek.Pages
{
    /// <summary>
    /// Interaction logic for BejelentkezesPage.xaml
    /// </summary>
    public partial class BejelentkezesPage : Page
    {
        public BejelentkezesPage()
        {
            InitializeComponent();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordBox.Password;

            // Basic sign-in logic placeholder
            if (email == "test@example.com" && password == "password")
            {
                MessageBox.Show("Sign in successful!");
                // Navigate to the main window or dashboard
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }
    }
}
