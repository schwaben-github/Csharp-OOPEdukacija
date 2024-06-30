using System;
using System.Collections.Generic;
using System.Linq;

List<int> brojevi = new List<int>();
int unos;
do
{
    Console.Write("Unesite broj: ");
    unos = int.Parse(Console.ReadLine());
    brojevi.Add(unos);
} while (unos != 0);

char odabir;
do
{
    Console.WriteLine();
    Console.WriteLine("Odaberite opciju:");
    Console.WriteLine("a: Ispis brojeva iz intervala [1, 11]");
    Console.WriteLine("b: Ispis brojeva i kvadrata većih od 20");
    Console.WriteLine("c: Ispis brojeva i njihove frekvencije");
    Console.WriteLine("d: Ispis brojeva većih od 80");
    Console.WriteLine("e: Ispis tri najveća broja");
    Console.WriteLine("x: Izlaz");
    odabir = Console.ReadKey().KeyChar;
    Console.WriteLine();

    switch (odabir)
    {
        case 'a':
            IspisBrojeva(brojevi);
            break;
        case 'b':
            IspisKvadrata(brojevi);
            break;
        case 'c':
            IspisFrekvencije(brojevi);
            break;
        case 'd':
            IspisBrojevaVecihOd80(brojevi);
            break;
        case 'e':
            IspisTriNajveca(brojevi);
            break;
        case 'x':
            break;
        default:
            Console.WriteLine("Nepoznata opcija");
            break;
    }
} while (odabir != 'x');

static void IspisBrojeva(List<int> brojevi)
{
    var upit = from broj in brojevi
               where broj >= 1 && broj <= 11
               select broj;
    foreach (var broj in upit)
    {
        Console.WriteLine($"Broj iz intervala 1,11: {broj}. ");
    }
    Console.WriteLine("--------------------------------------");
    Console.WriteLine();
}

static void IspisKvadrata(List<int> brojevi)
{
    var upit = from broj in brojevi
               where broj * broj > 20
               select broj * broj;
    foreach (var broj in upit)
    {
        Console.WriteLine("-------------- Prva verzija -------------");
        Console.WriteLine($"Kvadrat veci od 20: {broj}. ");
    }
    Console.WriteLine("--------------------------------------");
    Console.WriteLine();

    // ekvivalentno
    var upit2 = from broj in brojevi
                let kvadrat = broj * broj
                where kvadrat > 20
                select new { broj, kvadrat };
    foreach (var item in upit2)
    {
        Console.WriteLine("-------------- Druga verzija -------------");
        Console.WriteLine($"Kvadrat veci od 20: {item}. ");
    }
}

static void IspisFrekvencije(List<int> brojevi)
{
    var upit = from broj in brojevi
               group broj by broj into grupa
               select new { Broj = grupa.Key, Frekvencija = grupa.Count() };
    foreach (var broj in upit)
    {
        Console.WriteLine($"Broj {broj.Broj} pojavljuje se {broj.Frekvencija} puta. ");
    }
    Console.WriteLine("--------------------------------------");
    Console.WriteLine();
}

static void IspisBrojevaVecihOd80(List<int> brojevi)
{
    var upit = from broj in brojevi
               where broj > 80
               select broj;
    foreach (var broj in upit)
    {
        Console.WriteLine($"Broj veci od 80: {broj}.");
    }
    Console.WriteLine("--------------------------------------");
    Console.WriteLine();
}

static void IspisTriNajveca(List<int> brojevi)
{
    var upit = brojevi.OrderByDescending(broj => broj).Take(3);
    foreach (var broj in upit)
    {
        Console.WriteLine($"Jedan od tri najveca broja: {broj}.");
    }
    Console.WriteLine("--------------------------------------");
    Console.WriteLine();
}