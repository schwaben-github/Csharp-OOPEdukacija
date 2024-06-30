using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsobeZivotinje
{
    internal class Zivotinja : IComparable, ImojInterface
    {
        #region Maticna svojsva klase
        public string NarodniNaziv { get; set; }
        public string LatinskiNaziv { get; set; }
        #endregion Maticna svojsva klase

        #region Implementacija interfejsa
        public int CompareTo(object? obj)
        {
            Zivotinja zivotinja = obj as Zivotinja;
            return LatinskiNaziv.CompareTo(zivotinja.LatinskiNaziv);
        }

        public string PunoIme()
        {
            return $"{NarodniNaziv} ({LatinskiNaziv})";
        }
        #endregion Implementacija interfejsa
    }
}
