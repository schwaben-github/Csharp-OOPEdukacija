using System;

namespace ZnakRijeci
{
    public class ZnakRijeci
    {
        public string rijec;
        public char znak;

        public ZnakRijeci(string rijec, char znak)
        {
            this.rijec = rijec;
            this.znak = znak;
        }

        public int BrojPojavljivanja()
        {
            int brojac = 0;
            char maliZnak = char.ToLower(znak);

            foreach (char c in rijec)
            {
                if (char.ToLower(c) == maliZnak)
                {
                    brojac++;
                }
            }
            return brojac;
        }

        public void IspisiBrojPojavljivanja()
        {
            Console.WriteLine($"Znak {znak} se pojavljuje {BrojPojavljivanja()} puta u riječi {rijec}.");
        }
    }
}
