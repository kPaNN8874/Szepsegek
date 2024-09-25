using MySql.Data.MySqlClient;
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
    public class DataService
    {
        private string connectionString = "Server=localhost;Database=adatbazisnev;User ID=felhasznalonev;Password=jelszo;";

        // Vendégek lekérdezése a Vendeg táblából
        public List<Vendeg> GetVendegek()
        {
            List<Vendeg> vendegek = new List<Vendeg>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT vendeg_id, vendeg_v_nev, vendeg_k_nev, vendeg_tel, vendeg_mail, vendeg_pontok FROM Vendeg";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Vendeg vendeg = new Vendeg
                    {
                        VendegId = reader.GetInt32("vendeg_id"),
                        VezetekNev = reader.GetString("vendeg_v_nev"),
                        KeresztNev = reader.GetString("vendeg_k_nev"),
                        Telefon = reader.GetInt32("vendeg_tel"),
                        Email = reader.GetString("vendeg_mail"),
                        Pontok = reader.GetInt32("vendeg_pontok")
                    };
                    vendegek.Add(vendeg);
                }
            }

            return vendegek;
        }

        // Dolgozók lekérdezése a Dolgozók táblából
        public List<Dolgozo> GetDolgozok()
        {
            List<Dolgozo> dolgozok = new List<Dolgozo>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT dolgozo_id, dolgozo_v_nev, dolgozo_k_nev, szolgaltatas_id, dolgozo_tel, dolgozo_mail FROM Dolgozók";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Dolgozo dolgozo = new Dolgozo
                    {
                        DolgozoId = reader.GetInt32("dolgozo_id"),
                        VezetekNev = reader.GetString("dolgozo_v_nev"),
                        KeresztNev = reader.GetString("dolgozo_k_nev"),
                        SzolgaltatasId = reader.GetInt32("szolgaltatas_id"),
                        Telefon = reader.GetInt32("dolgozo_tel"),
                        Email = reader.GetString("dolgozo_mail")
                    };
                    dolgozok.Add(dolgozo);
                }
            }

            return dolgozok;
        }

        // Szolgáltatások lekérdezése a Szolgaltatas táblából
        public List<Szolgaltatas> GetSzolgaltatasok()
        {
            List<Szolgaltatas> szolgaltatasok = new List<Szolgaltatas>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT szolgaltatas_id, szolgaltatas_kategoria, szolgaltatas_idotartam, szolgaltatas_ar FROM Szolgaltatas";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Szolgaltatas szolgaltatas = new Szolgaltatas
                    {
                        SzolgaltatasId = reader.GetInt32("szolgaltatas_id"),
                        Kategoria = reader.GetString("szolgaltatas_kategoria"),
                        Idotartam = reader.GetInt32("szolgaltatas_idotartam"),
                        Ar = reader.GetInt32("szolgaltatas_ar")
                    };
                    szolgaltatasok.Add(szolgaltatas);
                }
            }

            return szolgaltatasok;
        }

        // Foglalások lekérdezése a Foglalas táblából
        public List<Foglalas> GetFoglalasok()
        {
            List<Foglalas> foglalasok = new List<Foglalas>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT foglalas_id, szolgaltatas_id, dolgozo_id, vendeg_id, foglalas_kezdes_idop, foglalas_befejezes_idop FROM Foglalas";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Foglalas foglalas = new Foglalas
                    {
                        FoglalasId = reader.GetInt32("foglalas_id"),
                        SzolgaltatasId = reader.GetInt32("szolgaltatas_id"),
                        DolgozoId = reader.GetInt32("dolgozo_id"),
                        VendegId = reader.GetInt32("vendeg_id"),
                        KezdesIdopont = reader.GetDateTime("foglalas_kezdes_idop"),
                        BefejezesIdopont = reader.GetDateTime("foglalas_befejezes_idop")
                    };
                    foglalasok.Add(foglalas);
                }
            }

            return foglalasok;
        }
    }

}