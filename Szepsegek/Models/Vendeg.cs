using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Szepsegek
{
	public class Vendeg
	{
        public Vendeg(MySqlDataReader reader)
        {
            VendegId = reader.GetInt32("vendeg_id");
            VezetekNev = reader.GetString("vendeg_v_nev");
            KeresztNev = reader.GetString("vendeg_k_nev");
            Telefon = reader.GetInt32("vendeg_tel");
            Email = reader.GetString("vendeg_mail");
            Pontok = reader.GetInt32("vendeg_pontok");
        }


        public int VendegId { get; set; }
		public string VezetekNev { get; set; }
		public string KeresztNev { get; set; }
		public int Telefon { get; set; }
		public string Email { get; set; }
        public int Pontok { get; set; }
	}
}
