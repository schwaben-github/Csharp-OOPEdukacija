using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VozilaApp
{
    internal class Brod : Vozilo
    {
        public delegate void NaPromjenuIstisnineDelegat(object sender, EventArgs e);
        public event NaPromjenuIstisnineDelegat NaPromjenuIstisnine;
        private double istisnina;
        public double Istisnina 
        { 
            get
            {
                return istisnina;
            }
            set
            {
                istisnina = value;
                if (NaPromjenuIstisnine != null)
                {
                    NaPromjenuIstisnine(this, new EventArgs());
                }
            }
        }
    }
}
