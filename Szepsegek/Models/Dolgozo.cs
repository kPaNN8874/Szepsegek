using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szepsegek
{
	public class Dolgozo
	{
        public Dolgozo(MySqlDataReader reader)
        {
            DolgozoId = reader.GetInt32("dolgozo_id");
            VezetekNev = reader.GetString("dolgozo_v_nev");
            KeresztNev = reader.GetString("dolgozo_k_nev");
            SzolgaltatasId = reader.GetInt32("szolgaltatas_id");
            Telefon = reader.GetString("dolgozo_tel");
            Email = reader.GetString("dolgozo_mail");
        }

        public Dolgozo(int dolgozoId, string vezetekNev, string keresztNev, int szolgaltatasId, string telefon, string email)
        {
            DolgozoId = dolgozoId;
            VezetekNev = vezetekNev;
            KeresztNev = keresztNev;
            SzolgaltatasId = szolgaltatasId;
            Telefon = telefon;
            Email = email;
        }

        public int DolgozoId { get; set; }
		public string VezetekNev { get; set; }
		public string KeresztNev { get; set; }
		public int SzolgaltatasId { get; set; }
		public string Telefon { get; set; }
		public string Email { get; set; }
	}
}
