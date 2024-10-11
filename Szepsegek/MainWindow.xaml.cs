using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;
using System.Numerics;
using System.Windows;
using System.Windows.Navigation;
using Szepsegek.Pages;
using Szepsegek.Services;
namespace Szepsegek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        private DataService _dataService;

        public ObservableCollection<Szolgaltatas> Szolgaltatasok { get; set; }
        public ObservableCollection<Dolgozo> Dolgozok { get; set; }
        public ObservableCollection<Vendeg> Vendegek { get; set; }
        public ObservableCollection<Foglalas> Foglalasok { get; set; }


        public MainWindow()
        {
            _dataService = new DataService();
            Szolgaltatasok = new ObservableCollection<Szolgaltatas>();
            Dolgozok = new ObservableCollection<Dolgozo>();
            Vendegek = new ObservableCollection<Vendeg>();
            Foglalasok = new ObservableCollection<Foglalas>();
            this.DataContext = _dataService;
            InitializeComponent();
        }
       private List<Dolgozo> Dolgozo()
        {
            return [
                new Dolgozo(1,"Asd", "Ibolya", 2, "36704562387", "asd.Ibolyka@gmail.com")
                ];
        }

        private void HomePage_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Szolgaltatasok_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new SzolgáltatásokPage();
        }

        private void Dolgozoink_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new DolgozoinkPage();
        }

        private void Szalon_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new SzalonInfoPage();
        }

        private void IdopontFoglalas_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new FoglalasPage();

        }

        private void Bejelentkezes_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new BejelentkezesPage();
        }
    }

}