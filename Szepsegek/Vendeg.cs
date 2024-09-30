using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Szepsegek
{
	public class Vendeg
	{
        public Vendeg(int vendegId, string vezetekNev, string keresztNev, int telefon, string email, int pontok)
        {
            VendegId = vendegId;
            VezetekNev = vezetekNev;
            KeresztNev = keresztNev;
            Telefon = telefon;
            Email = email;
            Pontok = pontok;
        }

        public int VendegId { get; set; }
		public string VezetekNev { get; set; }
		public string KeresztNev { get; set; }
		public int Telefon { get; set; }
		public string Email { get; set; }
        public int Pontok { get; set; }
	}
}
