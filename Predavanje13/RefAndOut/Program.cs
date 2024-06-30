// unos broja
using RefAndOut;

Console.WriteLine("Unesite broj: ");
int unos = int.Parse(Console.ReadLine()); // npr. 5

// ispis broja
Ispis(unos); // Iznos broja je: 5.

// pozvati metodu kojoj broj prosljeđujemo po vrijednosti
Inkrementiraj(unos); // broj se ne mijenja

// ispis
Ispis(unos); // Iznos broja je: 5.


// pozvati metodu kojoj broj prosljeđujemo po referenci
Inkrementiraj(ref unos); // broj se mijenja!!!

// ispis
Ispis(unos); // Iznos broja je: 6.


// kreirati instancu klase Osoba
Osoba o = new Osoba();
{ 
    o.Ime = "Tibor";
    o.Prezime = "Weigand";
};

Console.WriteLine(o.Ime); // Tibor
PromijeniIme(o); // mijenjamo ime osobe
Console.WriteLine(o.Ime); // Novo ime


Osoba o2;
// Console.WriteLine(o2.Prezime); // objekt o2 je null, jer nije inicijaliziran!
PromijeniPrezime(out o2); // mijenjamo prezime osobe
Console.WriteLine(o2.Prezime); // Novo prezime

partial class Program
{
    static void Inkrementiraj(int broj)
    {
        broj++; // broj = broj + 1; Ali broj se ne mijenja jer je proslijeđen po vrijednosti!
    }
    static void Ispis(int broj)
    {
        Console.WriteLine($"Iznos broja je: {broj}."); // Iznos broja je: 5.
    }
    static void Inkrementiraj(ref int broj) // ref - proslijeđujemo po referenci - overloaded metoda!
    {
        broj++; // broj = broj + 1; Broj se mijenja jer je proslijeđen po referenci!
    }

    static void PromijeniIme(Osoba osoba) // proslijeđujemo po referenci
    {
        osoba.Ime = "Jozo"; // mijenjamo ime osobe
    }

    static void PromijeniPrezime(out Osoba osoba) // proslijeđujemo po referenci
    {
        osoba = new Osoba(); // inicijaliziramo objekt
        osoba.Prezime = "Parmačević"; // mijenjamo prezime osobe
    }
}
