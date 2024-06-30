using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsi3
{
    internal class Osoba : IDetalji, ICloneable, IComparable
    {
        public int Starost { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public object Clone()
        {
            Osoba klon = new Osoba();
            klon.Ime = Ime;
            klon.Prezime = Prezime;
            klon.Starost = Starost;
            return klon;
        }

        public int CompareTo(object? obj)
        {
            // Metoda CompareTo trebala bi vratiti -1 ako je objekt manji od trenutnog,
            // 0 ako su jednaki, i 1 ako je objekt veci od trenutnog

            Osoba osoba = obj as Osoba; // ili (Osoba)obj;
            return Prezime.CompareTo(osoba.Prezime);
        }

        public string Detalji()
        {
            return $"{Ime} {Prezime}, {Starost} godina";
        }
    }
}
