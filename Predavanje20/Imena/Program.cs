// Napiši program koji traži unos imena sve dok se ne unese riječ „kraj”.
// Na konzoli ispisuje sva imena koja sadrže slovo „a” uz pomoc LINQ upita.
// Program mora podržavati velika i mala slova.

using System;
using System.Collections.Generic;
using System.Linq;

List<string> imena = new List<string>();
string unos = "";
do
{
    Console.Write("Unesite ime: ");
    unos = Console.ReadLine();
    if (unos.ToLower() != "kraj")
    {
        imena.Add(unos);
    }
} while (unos.ToLower() != "kraj");

IEnumerable<string> imenaSaSlovomA = imena.Where(i => i.ToLower().Contains("a"));
foreach (var ime in imenaSaSlovomA)
{
    Console.WriteLine(ime);
}
