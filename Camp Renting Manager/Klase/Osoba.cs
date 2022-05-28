using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camp_Renting_Manager.Klase
{
    public abstract class Osoba : Object
    {
        public int ID{ get; set; }
        public string Ime{ get; set; }
        public string Prezime { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
