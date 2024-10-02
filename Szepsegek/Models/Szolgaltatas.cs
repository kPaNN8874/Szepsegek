using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szepsegek
{
	public class Szolgaltatas
	{
       
        public Szolgaltatas(MySqlDataReader reader)
        {
            SzolgaltatasId = reader.GetInt32("szolgaltatas_id");
            Kategoria = reader.GetString("szolgaltatas_kategoria");
            Idotartam = reader.GetInt32("szolgaltatas_idotartam");
            Ar = reader.GetInt32("szolgaltatas_ar");
        }

        public Szolgaltatas(int szolgaltatasId, string kategoria, int idotartam, int ar)
        {
            SzolgaltatasId = szolgaltatasId;
            Kategoria = kategoria;
            Idotartam = idotartam;
            Ar = ar;
        }

        public int SzolgaltatasId { get; set; }
		public string Kategoria { get; set; }
		public int Idotartam { get; set; }
		public int Ar { get; set; }
	}
}
