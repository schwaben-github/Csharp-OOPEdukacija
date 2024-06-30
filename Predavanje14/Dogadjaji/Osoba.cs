using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadjaji
{
    public class Osoba
    {
        // deklaracija događaja
        public delegate void NaPromjenaImenaDelegat(object sender, EventArgs e);
        public event NaPromjenaImenaDelegat NaPromjenaImena;

        // svojsvo
        private string ime;
        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                string oldIme = ime;
                ime = value;
                // pozivanje događaja
                // provjeri je li događaj implementiran

                if (NaPromjenaImena != null)
                {
                    NaPromjenaImena(this, EventArgs.Empty);
                }
            }
        }

    }
}
