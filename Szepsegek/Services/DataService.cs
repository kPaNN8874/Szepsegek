using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Szepsegek.Services
{
    internal class DataService
    {
        private string connectionString = "Server=localhost;Database=szepsegek;User ID=admin;Password=;";
        private MySqlConnection _connection;
        public DataService() { 
        _connection =new MySqlConnection(connectionString);
        }
        // Vendégek lekérdezése a Vendeg táblából
        public List<Vendeg> GetVendegek()
        {
            List<Vendeg> vendegek = new List<Vendeg>();

            using (MySqlConnection connection = _connection)
            {
                connection.Open();
                string query = "SELECT vendeg_id, vendeg_v_nev, vendeg_k_nev, vendeg_tel, vendeg_mail, vendeg_pontok FROM Vendeg";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    vendegek.Add(new Vendeg(reader));
                }
            }

            return vendegek;
        }

        // Dolgozók lekérdezése a Dolgozók táblából
        public List<Dolgozo> GetDolgozok()
        {
            List<Dolgozo> dolgozok = new List<Dolgozo>();

            using (MySqlConnection connection = _connection)
            {
                connection.Open();
                string query = "SELECT dolgozo_id, dolgozo_v_nev, dolgozo_k_nev, szolgaltatas_id, dolgozo_tel, dolgozo_mail FROM Dolgozók";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                 dolgozok.Add(new Dolgozo(reader)); 
                   
                }
            }

            return dolgozok;
        }

        // Szolgáltatások lekérdezése a Szolgaltatas táblából
        public List<Szolgaltatas> GetSzolgaltatasok()
        {
            List<Szolgaltatas> szolgaltatasok = new List<Szolgaltatas>();

            using (MySqlConnection connection = _connection)
            {
                connection.Open();
                string query = "SELECT szolgaltatas_id, szolgaltatas_kategoria, szolgaltatas_idotartam, szolgaltatas_ar FROM Szolgaltatas";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    szolgaltatasok.Add(new Szolgaltatas(reader));
                    
                }
            }

            return szolgaltatasok;
        }

        // Foglalások lekérdezése a Foglalas táblából
        public List<Foglalas> GetFoglalasok()
        {
            List<Foglalas> foglalasok = new List<Foglalas>();

            using (MySqlConnection connection = _connection)
            {
                connection.Open();
                string query = "SELECT foglalas_id, szolgaltatas_id, dolgozo_id, vendeg_id, foglalas_kezdes_idop, foglalas_befejezes_idop FROM Foglalas";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                   foglalasok.Add(new Foglalas(reader));
                }
                return foglalasok;
            }
        }
    }
}

