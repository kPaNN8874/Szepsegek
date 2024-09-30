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
        public Foglalas(int foglalasId, int szolgaltatasId, int dolgozoId, int vendegId, DateTime kezdesIdopont, DateTime befejezesIdopont)
        {
            FoglalasId = foglalasId;
            SzolgaltatasId = szolgaltatasId;
            DolgozoId = dolgozoId;
            VendegId = vendegId;
            KezdesIdopont = kezdesIdopont;
            BefejezesIdopont = befejezesIdopont;
        }

        public int FoglalasId { get; set; }
		public int SzolgaltatasId { get; set; }
		public int DolgozoId { get; set; }
		public int VendegId { get; set; }
		public DateTime KezdesIdopont { get; set; }
		public DateTime BefejezesIdopont { get; set; }
	}
    

   
   }


    