using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VozilaApp
{
    public class Vozilo
    {
        public string Naziv { get; set; }
        public string Boja { get; set; }
        public int KS { get; set; }

        public double KSuKW()
        {
            return KS * 0.736;
        }
    }
}
