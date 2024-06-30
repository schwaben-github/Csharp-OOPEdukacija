using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOsobaApp
{
    internal class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string PunoIme()
        {
            return Ime + " " + Prezime;
        }

        public Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }
    }
}
