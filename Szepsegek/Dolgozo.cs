using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szepsegek
{
	public class Dolgozo
	{
        public Dolgozo(int dolgozoId, string vezetekNev, string keresztNev, int szolgaltatasId, int telefon, string email)
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
		public int Telefon { get; set; }
		public string Email { get; set; }
	}
}
