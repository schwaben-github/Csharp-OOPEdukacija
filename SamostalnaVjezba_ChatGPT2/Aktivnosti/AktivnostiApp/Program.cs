using System;

namespace AktivnostiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();
            Console.WriteLine("Unesi ime osobe:");
            osoba.Ime = Console.ReadLine();
            Console.WriteLine("Unesi dob osobe:");
            osoba.Dob = byte.Parse(Console.ReadLine());
            Console.WriteLine("Unesi visinu osobe:");
            osoba.Visina = float.Parse(Console.ReadLine());
            Console.WriteLine("Unesi masu osobe:");
            osoba.Masa = byte.Parse(Console.ReadLine());

            Console.WriteLine("Odaberi aktivnost:");
            Console.WriteLine("1. Hodanje");
            Console.WriteLine("2. Govor");
            Console.WriteLine("3. Hranjenje");
            Console.WriteLine("4. Spavanje");
            int aktivnost = int.Parse(Console.ReadLine());

            switch (aktivnost)
            {
                case 1:
                    osoba.Hodanje += (sender, e) => Console.WriteLine($"{osoba.Ime} je hodao 150 metara");
                    osoba.Hodaj();
                    break;
                case 2:
                    osoba.Pricanje += (sender, e) => Console.WriteLine($"{osoba.Ime} je nesto rekao");
                    osoba.Govori();
                    break;
                case 3:
                    osoba.Hranjenje += (sender, e) => Console.WriteLine($"{osoba.Ime} se hrani");
                    osoba.Jedi();
                    break;
                case 4:
                    osoba.Spavanje += (sender, e) => Console.WriteLine($"{osoba.Ime} spava...");
                    osoba.Spavaj();
                    break;
                default:
                    Console.WriteLine("Nepoznata aktivnost");
                    break;
            }
        }
    }
}