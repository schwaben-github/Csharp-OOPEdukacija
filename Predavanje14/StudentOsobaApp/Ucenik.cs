using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOsobaApp
{
    internal class Ucenik : Osoba
    {
        public Ucenik(string ime, string prezime) : base(ime, prezime)
        {
        }

        public int Matematika { get; set; }
        public int Fizika { get; set; }
        public int Kemija { get; set; }

        public double VratiProsjek()
        {
            return (Matematika + Fizika + Kemija) / 3.0;
        }

        public override string ToString()
        {
            return PunoIme() + ", prosjek: " + VratiProsjek();
        }
    }
}
