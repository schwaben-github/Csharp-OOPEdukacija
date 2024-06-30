using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutomobilApp
{
    internal class Automobil
    {
        // Enkapsulacija

        // Svojstva
        #region Svojstva
        private string marka;

        public string Marka 
        {
            get 
            { 
                return marka; 
            }
            set 
            {
                // value predstavlja vrijednost koja se dodjeljuje svojstvu
                marka = value; 
            }
        }

        private double ks;
        public double KS
        {
            get
            {
                return ks;
            }
            set
            {
                ks = value;
            }
        }

        private double osnovnaCijena;
        public double OsnovnaCijena
        {
            get
            {
                return osnovnaCijena;
            }
            set
            {
                if (value > 0)
                {
                    osnovnaCijena = value;
                }
                else
                {
                    throw new Exception("Osnovna cijena ne može biti negativna.");
                }
            }
        }
        #endregion

        // Metode
        #region Metode

        public double IznosPoreza()
        {
            if (KS <= 50)
            {
                return OsnovnaCijena * 0.05;
            }
            else if (KS > 50 && KS <= 150)
            {
                return OsnovnaCijena * 0.1;
            }
            else
            {
                return OsnovnaCijena * 0.15;
            }
        }

        public double UkupnaCijena()
        {
            return OsnovnaCijena + IznosPoreza();
        }
        #endregion
    }
    /* Varijanta 2
     * {
         public string Marka { get; set; }
         public double KS { get; set; }
         public double OsnovnaCijena { get; set; }

         public double IznosPoreza()
         {
             if (KS <= 50)
             {
                 return OsnovnaCijena * 0.05;
             }
             else if (KS <= 150)
             {
                 return OsnovnaCijena * 0.1;
             }
             else
             {
                 return OsnovnaCijena * 0.15;
             }
         }

         public double UkupnaCijena()
         {
             return OsnovnaCijena + IznosPoreza();
         }
     }*/
}
