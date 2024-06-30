using System;

namespace RijecRecenice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite rečenicu:");
            string recenica = Console.ReadLine();

            Brojac brojac = new Brojac(recenica);

            brojac.IspisiBrojRijeci();
            Console.WriteLine();

            brojac.IspisiBrojPojavljivanjaRijeci();

            Console.ReadKey();
        }
    }
}