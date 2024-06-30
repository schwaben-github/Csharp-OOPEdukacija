using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktori
{
    internal class Osoba
    {
        // 1. Svojstva klase Osoba
        public string Ime { get; set; }
        public string Prezime { get; set; }

        // 2. Konstruktor bez parametara
        // Defaultni konstruktor
        public Osoba()
        {
            
        }

        // 3. Parametrizirani Konstruktor
        public Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }

        // 4. Parametrizirani Konstruktor
        public Osoba(string naziv, bool prezime)
        {
            if (prezime) // ekvivalentno if(prezime == true)
            {
                Prezime = naziv;
            }
            else
            {
                Ime = naziv;
            }
        }
    }
}
