using System;
using System.Collections.Generic;
using System.Linq;

string unos;
char odabir;

Console.WriteLine("Unesite neki string:");
unos = Console.ReadLine();

do
{
    Console.WriteLine();
    Console.WriteLine("Odaberite opciju:");
    Console.WriteLine("a: Ispis znakova i njihove frekvencije");
    Console.WriteLine("b: Ispis riječi napisanih velikim slovima");
    Console.WriteLine("x: Izlaz");
    odabir = Console.ReadKey().KeyChar;
    Console.WriteLine();

    switch (odabir)
    {
        case 'a':
            IspisZnakova(unos);
            break;
        case 'b':
            IspisRijeci(unos);
            break;
        case 'x':
            break;
        default:
            Console.WriteLine("Nepoznata opcija");
            break;
    }
} while (odabir != 'x');

static void IspisZnakova(string unos)
{
    var upit = from znak in unos.ToUpper()
               where znak != ' '
               group znak by znak into grupa
               select new { Znak = grupa.Key, Frekvencija = grupa.Count() };
    foreach (var znak in upit)
    {
        Console.WriteLine($"Znak: {znak.Znak}, Frekvencija: {znak.Frekvencija}");
    }
    Console.WriteLine("--------------------------------------");
    Console.WriteLine();
}

static void IspisRijeci(string unos)
{
    var upit = from rijec in unos.Replace(".", "").Replace(",", "").Replace("!", "").Replace("?", "").Split(' ')
               where rijec.All(char.IsUpper) && !string.IsNullOrEmpty(rijec)
               select rijec;
    foreach (var rijec in upit)
    {
        Console.WriteLine($"Rijec napisana velikim slovima: {rijec}");
    }
    Console.WriteLine("--------------------------------------");
    Console.WriteLine();
}