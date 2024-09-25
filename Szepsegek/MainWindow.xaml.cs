using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Szepsegek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class Vendeg
    {
        public int VendegId { get; set; }
        public string VezetekNev { get; set; }
        public string KeresztNev { get; set; }
        public int Telefon { get; set; }
        public string Email { get; set; }
        public int Pontok { get; set; }
    }

    public class Dolgozo
    {
        public int DolgozoId { get; set; }
        public string VezetekNev { get; set; }
        public string KeresztNev { get; set; }
        public int SzolgaltatasId { get; set; }
        public int Telefon { get; set; }
        public string Email { get; set; }
    }

    public class Szolgaltatas
    {
        public int SzolgaltatasId { get; set; }
        public string Kategoria { get; set; }
        public int Idotartam { get; set; }
        public int Ar { get; set; }
    }

    public class Foglalas
    {
        public int FoglalasId { get; set; }
        public int SzolgaltatasId { get; set; }
        public int DolgozoId { get; set; }
        public int VendegId { get; set; }
        public DateTime KezdesIdopont { get; set; }
        public DateTime BefejezesIdopont { get; set; }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}