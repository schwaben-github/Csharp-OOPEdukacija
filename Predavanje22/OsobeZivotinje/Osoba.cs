using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsobeZivotinje
{
    internal class Osoba : ImojInterface, IDisposable, ICloneable, IComparable
    {
        #region Maticna svojsva klase
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Osoba Partner { get; set; }
        #endregion Maticna svojsva klase

        #region Implementacija interfejsa
        public object Clone()
        {
            // Implementacija kloniranja
            Osoba klon = new Osoba();
            klon.Ime = Ime;
            klon.Prezime = Prezime;

            return klon;
        }

        public int CompareTo(object? obj)
        {
            // Implementacija metode CompareTo
            Osoba o = obj as Osoba;
            return Prezime.CompareTo(o.Prezime);
        }

        public void Dispose()
        {
            // Implementacija metode Dispose
            Partner = null;
        }


        public string PunoIme()
        {
            return $"{Ime} {Prezime}";
        }
        #endregion Implementacija interfejsa
    }
}
