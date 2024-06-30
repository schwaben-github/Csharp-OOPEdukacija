// Napiši program koji traži unos brojeva sve dok korisnik ne unese broj 0.
// Na konzoli se ispisuje broj parnih i broj neparnih brojeva pronađenih pomoću LINQ upita.

using System;
using System.Collections.Generic;
using System.Linq;

List<int> numbers = new List<int>();


int number;
do
{
    Console.Write("Unesite broj ili 0 za kraj unosa: ");
    if (int.TryParse(Console.ReadLine(), out number))
    {
        numbers.Add(number);
    }
    else
    {
        Console.WriteLine("Niste unijeli ispravan broj. Molimo pokušajte ponovno.");
    }
} while (number != 0);


int countEven = numbers.Count(n => n % 2 == 0);
int countOdd = numbers.Count(n => n % 2 != 0);


Console.WriteLine($"Broj parnih brojeva: {countEven}");
Console.WriteLine($"Broj neparnih brojeva: {countOdd}");

Console.WriteLine("--------------------------------------------------");

int countEven2 = (from n in numbers
                  where n % 2 == 0
                  select n).Count();
int countOdd2 = (from n in numbers
                 where n % 2 != 0
                 select n).Count();

Console.WriteLine($"Broj parnih brojeva: {countEven2}");
Console.WriteLine($"Broj neparnih brojeva: {countOdd2}");

/*List<int> brojevi = new List<int>();
int broj;
do
{
    Console.Write("Unesite broj: ");
    broj = int.Parse(Console.ReadLine());
    if (broj != 0)
    {
        brojevi.Add(broj);
    }
} while (broj != 0);

Console.WriteLine();
var parniNeparni = brojevi.GroupBy(b => b % 2 == 0 ? "parni" : "neparni")
    .Select(g => new { Tip = g.Key, Broj = g.Count() });
Console.WriteLine();
foreach (var parniNeparniBrojevi in parniNeparni)
{
    Console.WriteLine($"{parniNeparniBrojevi.Tip}: {parniNeparniBrojevi.Broj}");
}
Console.WriteLine("----------------------------------------");*/


/*int broj;
int brojParnih = 0;
int brojNeparnih = 0;

do
{
    Console.Write("Unesite broj: ");
    broj = int.Parse(Console.ReadLine());
    if (broj % 2 == 0)
    {
        brojParnih++;
    }
    else
    {
        brojNeparnih++;
    }
} while (broj != 0);
*/