using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje
{
    // klasa Clan nasljeđuje klasu Osoba
    internal class Clan : Osoba
    {
        public string ClanskiBroj { get; set; }

        public Clan(string ime, string prezime) : base(ime, prezime)
        {
        }

        public string Detalji()
        {
            return PunoIme() + ", ID: " + ClanskiBroj;
        }

        public new string PunoIme()
        {
            return Prezime + " " + Ime;
        }

        public override string ToString()
        {
            return Detalji();
        }
    }
}
