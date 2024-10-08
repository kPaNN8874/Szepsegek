﻿using System;
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

            // Placeholder login logic
            if (email == "admin" && password == "admin")
            {
                MessageBox.Show("Login successful!");
                //BejelentkezettPage mainWindow = new BejelentkezettPage();
                //mainWindow.Content = new BejelentkezettPage();
                BejelentkezettPage loggedInPage = new BejelentkezettPage();
                NavigationService.Navigate(loggedInPage);
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }
    }
}