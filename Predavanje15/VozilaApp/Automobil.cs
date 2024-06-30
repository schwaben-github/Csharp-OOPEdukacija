using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VozilaApp
{
    internal class Automobil : Vozilo
    {
        public double ccm { get; set; }

        public override string ToString()
        {
            return string.Format("Naziv {0}, KS {1}", Naziv, KS);
        }
    }
}
