using MySql.Data.MySqlClient;
namespace Szepsegek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public class DataService
    {
        private string connectionString = "Server=localhost;Database=szepsegek;User ID=admin;Password=;";

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
                    Dolgozo dolgozo = new Dolgozo()
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
                    Szolgaltatas szolgaltatas = new Szolgaltatas(1,"klet",12,1)
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
                return foglalasok;
            }
        }
    }

}