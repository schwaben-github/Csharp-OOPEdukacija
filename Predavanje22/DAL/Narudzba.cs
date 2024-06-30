using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Narudzba
    {
        public delegate void NarudzbaKreiranaDelegate(object sender, EventArgs e);
        public event NarudzbaKreiranaDelegate NarudzbaKreirana;

        private DateTime datumKreiranja;
        public DateTime DatumKreiranja
        {
            get
            {
                return datumKreiranja;
            }
            set
            {
                datumKreiranja = value;
                if (NarudzbaKreirana != null)
                {
                    NarudzbaKreirana(this, new EventArgs());
                }
            }
        }
        public bool DostavaIzvrsena { get; set; }

        public Proizvodi Proizvodi { get; set; }

        public decimal UkupnaCijena { get; set; }
    }
}
