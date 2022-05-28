using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camp_Renting_Manager.Klase
{
    public class Rezervacija
    {
        public int OznakaRezervacije { get; set; }
        public int OznakaSJ { get; set; }
        public DateTime TerminPocetak { get; set; }
        public DateTime TerminKraj { get; set; }
        public DateTime DatumStvaranja { get; set; }
        public int IDKorisnika { get; set; }
    }
}
