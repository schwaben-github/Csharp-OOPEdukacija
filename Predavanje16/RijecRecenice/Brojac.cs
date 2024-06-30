using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RijecRecenice
{
    internal class Brojac
    {
        public static int BrojPonavljanjaRijeciURecenici(string recenica, string rijec)
        {
            string[] rijeci = recenica.Split(' ');
            int brojPonavljanja = 0;

            foreach (string r in rijeci)
            {
                if (r.ToLower() == rijec.ToLower())
                {
                    brojPonavljanja++;
                }
            }

            return brojPonavljanja;
        }
    }
}
