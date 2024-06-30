// Napiši program koji traži unos jedne rečenice i unos jedne rječi i zatim ispisuje koliko se puta ta riječ pojavljuje u toj rečenici.
// Program treba ignorirati velika i mala slova. Npr. riječ "auto" se pojavljuje 2 puta u rečenici "Auto je auto".

using System;

namespace RijecRecenice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite recenicu:");
            string recenica = Console.ReadLine();

            Console.WriteLine("Unesite rijec:");
            string rijec = Console.ReadLine();

            int brojPonavljanja = Brojac.BrojPonavljanjaRijeciURecenici(recenica, rijec);
            Console.WriteLine($"Rijec '{rijec}' se pojavljuje {brojPonavljanja} puta u recenici.");
        }
    }
}
