using System;

namespace ZnakRijeci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite riječ: ");
            string rijec = Console.ReadLine();
            Console.Write("Unesite znak: ");
            char znak = Console.ReadKey().KeyChar;
            Console.WriteLine();

            ZnakRijeci znakRijeci = new ZnakRijeci(rijec, znak);

            znakRijeci.IspisiBrojPojavljivanja();

            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlazak iz programa.");
            Console.ReadKey();
        }
    }
}