using System;
using System.Collections.Generic;
using System.Linq;

List<string> rijeci = new List<string>();
string unos;
do
{
    Console.WriteLine("Unesite riječ:");
    unos = Console.ReadLine();
    if (unos != "kraj")
    {
        rijeci.Add(unos);
    }
} while (unos != "kraj");

char odabir;
do
{
    Console.WriteLine();
    Console.WriteLine("Odaberite opciju:");
    Console.WriteLine("a: Riječi koje počinju i završavaju određenim slovima");
    Console.WriteLine("b: String sa svim upisanim stringovima odvojenim zarezima");
    Console.WriteLine("c: Stringovi minimalne duljine");
    Console.WriteLine("d: Stringovi poredani po duljini uzlazno a zatim po imenu");
    Console.WriteLine("e: Jedinstveni stringovi poredani po abecedi");
    Console.WriteLine("x: Izlaz");
    odabir = Console.ReadKey().KeyChar;
    Console.WriteLine();

    switch (odabir)
    {
        case 'a':
            RijeciKojePocinjuZavrsavaju(rijeci);
            break;
        case 'b':
            StringSaStringovima(rijeci);
            break;
        case 'c':
            StringoviMinimalneDuljine(rijeci);
            break;
        case 'd':
            StringoviPoredaniPoDuljini(rijeci);
            break;
        case 'e':
            JedinstveniStringovi(rijeci);
            break;
        case 'x':
            break;
        default:
            Console.WriteLine("Nepoznata opcija");
            break;
    }
} while (odabir != 'x');

static void RijeciKojePocinjuZavrsavaju(List<string> rijeci)
{
    Console.WriteLine("Unesite početno slovo:");
    char pocetnoSlovo = char.Parse(Console.ReadLine().ToLower());
    Console.WriteLine("Unesite završno slovo:");
    char zavrsnoSlovo = char.Parse(Console.ReadLine().ToLower());

    var upit = from rijec in rijeci
               where rijec.StartsWith(pocetnoSlovo.ToString(), StringComparison.OrdinalIgnoreCase)
               where rijec.EndsWith(zavrsnoSlovo.ToString(), StringComparison.OrdinalIgnoreCase)
               select rijec;
    foreach (var rijec in upit)
    {
        Console.WriteLine($"Riječ koja počinje slovom {pocetnoSlovo} i završava slovom {zavrsnoSlovo}: {rijec}");
    }
    Console.WriteLine("--------------------------------------");
}

static void StringSaStringovima(List<string> rijeci)
{
    var upit = string.Join(", ", rijeci);
    Console.WriteLine($"String sa svim upisanim stringovima odvojenim zarezima: {upit}");
    Console.WriteLine("--------------------------------------");
}

static void StringoviMinimalneDuljine(List<string> rijeci)
{
    Console.WriteLine("Unesite minimalnu duljinu:");
    int duljina = int.Parse(Console.ReadLine());

    var upit = from rijec in rijeci
               where rijec.Length >= duljina
               select rijec;
    foreach (var rijec in upit)
    {
        Console.WriteLine($"String minimalne duljine {duljina}: {rijec}");
    }
    Console.WriteLine("--------------------------------------");
}

static void StringoviPoredaniPoDuljini(List<string> rijeci)
{
    var upit = from rijec in rijeci
               orderby rijec.Length, rijec
               select rijec;
    foreach (var rijec in upit)
    {
        Console.WriteLine($"String poredan po duljini uzlazno a zatim po imenu: {rijec}");
    }
    Console.WriteLine("--------------------------------------");
}

static void JedinstveniStringovi(List<string> rijeci)
{
    var upit = rijeci.Distinct().OrderBy(rijec => rijec);
    foreach (var rijec in upit)
    {
        Console.WriteLine($"Jedinstveni stringovi poredani po abecedi: {rijec}");
    }
    Console.WriteLine("--------------------------------------");
}
