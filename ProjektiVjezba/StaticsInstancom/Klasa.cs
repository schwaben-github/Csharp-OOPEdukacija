using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// Napravi klasu koja ima: static funkciju koja vraća je li broj prost ili složen,
// metodu na instanci koja ispituje je li broj savršen (jednak zbroju svih svojih djelitelja osim njega samoga

namespace StaticsInstancom
{
    internal class Klasa
    {
        public static bool Prost(int broj)
        {
            if (broj < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(broj); i++)
            {
                if (broj % i == 0)
                    return false;
            }

            return true;
        }

        public bool Savrsen(int broj)
        {
            int zbroj = 0;
            for (int i = 1; i < broj; i++)
            {
                if (broj % i == 0)
                    zbroj += i;
            }

            return zbroj == broj;
        }
    }
}
