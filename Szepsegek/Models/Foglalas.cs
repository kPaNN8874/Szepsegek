using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szepsegek
{
	public class Foglalas 
	{
        public Foglalas(MySqlDataReader reader)
        {
            FoglalasId = reader.GetInt32("foglalas_id");
            SzolgaltatasId = reader.GetInt32("szolgaltatas_id");
            DolgozoId = reader.GetInt32("dolgozo_id");
            VendegId = reader.GetInt32("vendeg_id");
            KezdesIdopont = reader.GetDateTime("foglalas_kezdes_idop");
            BefejezesIdopont = reader.GetDateTime("foglalas_befejezes_idop");
        }

        public int FoglalasId { get; set; }
		public int SzolgaltatasId { get; set; }
		public int DolgozoId { get; set; }
		public int VendegId { get; set; }
		public DateTime KezdesIdopont { get; set; }
		public DateTime BefejezesIdopont { get; set; }
	}
    

   
   }


    