using System;
using System.Collections.Generic;
using System.Text;using System;

namespace KolikoPonavljanja
{
    internal class PonavljanjeRijeci
    {
        public string Recenica { get; set; }
        public string[] Rijeci { get; set; }

        public PonavljanjeRijeci(string recenica)
        {
            Recenica = recenica;
            Rijeci = Recenica.Split(' ');
        }

        public void IspisiPonavljanja()
        {
            foreach (string r in Rijeci)
            {
                Console.WriteLine($"Riječ {r} se pojavljuje {BrojPonavljanja(r)} puta.");
            }
        }

        private int BrojPonavljanja(string rijec)
        {
            int brojac = 0;
            string malaRijec = rijec.ToLower();

            foreach (string r in Rijeci)
            {
                if (r.ToLower() == malaRijec)
                {
                    brojac++;
                }
            }
            return brojac;
        }
    }
}
