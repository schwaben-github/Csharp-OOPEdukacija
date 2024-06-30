using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila
{
    public class Brod : Vozilo
    {
        public double Istisnina { get; set; }

        public event EventHandler NaPromjenuIstisnine;
        public void PromijeniIstisninu(double novaIstisnina)
        {
            Istisnina = novaIstisnina;
            NaPromjenuIstisnine?.Invoke(this, EventArgs.Empty);
        }
    }
}
