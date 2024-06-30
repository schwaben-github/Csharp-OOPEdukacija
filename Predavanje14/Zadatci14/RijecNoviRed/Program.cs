using System;

namespace RijecNoviRed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite rečenicu:");
            string recenica = Console.ReadLine();

            RijeciNoviRed rijeciNoviRed = new RijeciNoviRed(recenica);

            Console.ReadKey();
        }
    }
}