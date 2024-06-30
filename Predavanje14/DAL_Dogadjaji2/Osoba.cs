using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Dogadjaji2
{
    public class Osoba
    {
        //deklaracija događaja
        public delegate void NaPromjenuImenaDelegat(object sender, EventArgs e);
        public event NaPromjenuImenaDelegat NaPromjenuImena;

        public delegate void NaPozivPIDelegat(object sender, EventArgs e);
        public event NaPozivPIDelegat NaPozivPI;

        private string ime;
        private string prezime;
        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                ime = value;
                if (NaPromjenuImena != null)
                {
                    NaPromjenuImena(this, new EventArgs());
                }
            }
        }
        public string Prezime { get => prezime; set => prezime = value; }
        public string PunoIme()
        {
            if (NaPozivPI != null)
            {
                NaPozivPI(this, new EventArgs());
            }
            return Ime + " " + Prezime;
        }
    }
}