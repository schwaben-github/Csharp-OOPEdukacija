using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila
{
    public class Automobil : Vozilo
    {
        public double ccm { get; set; }

        public override string ToString()
        {
            return $"{Naziv}, {KS}";
        }
    }
}
