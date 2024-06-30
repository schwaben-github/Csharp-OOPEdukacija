using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje
{
    internal class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Osoba(string ime, string prezime) // parametrizirani konstruktor klase Osoba
        {
            Ime = ime;
            Prezime = prezime;
        }

        public string PunoIme() // metoda koja vraća puno ime osobe
        {
            return Ime + " " + Prezime; // vraća puno ime osobe
        }

        public override string ToString() // override metode ToString() iz klase Object
        {
            return PunoIme(); // pozivamo metodu PunoIme() koja vraća puno ime osobe
        }
    }
}
