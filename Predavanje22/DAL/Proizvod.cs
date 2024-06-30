using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Proizvod
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        private decimal ukupnaCijena;
        public decimal UkupnaCijena
        {
            get
            {
                return ukupnaCijena;
            }
        }
        private decimal jedCijena;
        public decimal JedCijena
        {
            get
            {
                return jedCijena;
            }
            set
            {
                jedCijena = value;
                ukupnaCijena = IzracunajPDV();
            }
        }
        public bool Dostupan { get; set; }
        public decimal IzracunajPDV()
        {
            return JedCijena * 1.25m;
        }

    }
}
