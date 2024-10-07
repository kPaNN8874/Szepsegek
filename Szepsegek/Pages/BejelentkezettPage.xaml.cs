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
    /// Interaction logic for BejelentkezettPage.xaml
    /// </summary>
    public partial class BejelentkezettPage : Page
    {
        public BejelentkezettPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Modifying personal information...");
        }
    }
}
