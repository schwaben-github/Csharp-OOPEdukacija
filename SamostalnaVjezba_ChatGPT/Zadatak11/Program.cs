// Napišite program koji simulira sustav za upravljanje knjižnicom.
// Program bi trebao omogućiti sljedeće funkcionalnosti:
// Dodavanje knjige u knjižnicu (svaka knjiga ima naslov, autora i godinu izdanja).
// Pretraga knjige po naslovu ili autoru.
// Ispis svih knjiga u knjižnici.
// Brisanje knjige iz knjižnice.

using System;
using System.Collections.Generic;

class Knjiga
{
    public string Naslov { get; set; }
    public string Autor { get; set; }
    public int GodinaIzdanja { get; set; }

    public Knjiga(string naslov, string autor, int godinaIzdanja)
    {
        Naslov = naslov;
        Autor = autor;
        GodinaIzdanja = godinaIzdanja;
    }
}

class Knjižnica
{
    private List<Knjiga> knjige = new List<Knjiga>();

    public void DodajKnjigu(Knjiga knjiga)
    {
        knjige.Add(knjiga);
    }

    public void IspišiSveKnjige()
    {
        foreach (Knjiga knjiga in knjige)
        {
            Console.WriteLine($"Naslov: {knjiga.Naslov}, Autor: {knjiga.Autor}, Godina izdanja: {knjiga.GodinaIzdanja}");
        }
    }

    public Knjiga PretragaPoNaslovu(string naslov)
    {
        foreach (Knjiga knjiga in knjige)
        {
            if (knjiga.Naslov == naslov)
            {
                return knjiga;
            }
        }
        return null;
    }

    public Knjiga PretragaPoAutoru(string autor)
    {
        foreach (Knjiga knjiga in knjige)
        {
            if (knjiga.Autor == autor)
            {
                return knjiga;
            }
        }
        return null;
    }

    public bool ObrišiKnjigu(string naslov)
    {
        Knjiga knjigaZaBrisanje = PretragaPoNaslovu(naslov);
        if (knjigaZaBrisanje != null)
        {
            knjige.Remove(knjigaZaBrisanje);
            return true;
        }
        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Knjižnica knjižnica = new Knjižnica();

        while (true)
        {
            Console.WriteLine("1. Dodaj knjigu");
            Console.WriteLine("2. Pretraži knjigu po naslovu");
            Console.WriteLine("3. Pretraži knjigu po autoru");
            Console.WriteLine("4. Ispiši sve knjige");
            Console.WriteLine("5. Obriši knjigu");
            Console.WriteLine("6. Izlaz");

            string izbor = Console.ReadLine();

            switch (izbor)
            {
                case "1":
                    Console.Write("Unesi naslov knjige: ");
                    string naslov = Console.ReadLine();
                    Console.Write("Unesi autora knjige: ");
                    string autor = Console.ReadLine();
                    Console.Write("Unesi godinu izdanja knjige: ");
                    int godinaIzdanja = int.Parse(Console.ReadLine());
                    knjižnica.DodajKnjigu(new Knjiga(naslov, autor, godinaIzdanja));
                    break;
                case "2":
                    Console.Write("Unesi naslov knjige: ");
                    naslov = Console.ReadLine();
                    Knjiga knjiga = knjižnica.PretragaPoNaslovu(naslov);
                    if (knjiga != null)
                    {
                        Console.WriteLine($"Naslov: {knjiga.Naslov}, Autor: {knjiga.Autor}, Godina izdanja: {knjiga.GodinaIzdanja}");
                    }
                    else
                    {
                        Console.WriteLine("Knjiga nije pronađena.");
                    }
                    break;
                case "3":
                    Console.Write("Unesi autora knjige: ");
                    autor = Console.ReadLine();
                    knjiga = knjižnica.PretragaPoAutoru(autor);
                    if (knjiga != null)
                    {
                        Console.WriteLine($"Naslov: {knjiga.Naslov}, Autor: {knjiga.Autor}, Godina izdanja: {knjiga.GodinaIzdanja}");
                    }
                    else
                    {
                        Console.WriteLine("Knjiga nije pronađena.");
                    }
                    break;
                case "4":
                    knjižnica.IspišiSveKnjige();
                    break;
                case "5":
                    Console.Write("Unesi naslov knjige: ");
                    naslov = Console.ReadLine();
                    if (knjižnica.ObrišiKnjigu(naslov))
                    {
                        Console.WriteLine("Knjiga je uspješno obrisana.");
                    }
                    else
                    {
                        Console.WriteLine("Knjiga nije pronađena.");
                    }
                    break;
                case "6":
                    return; // Izlaz iz programa
                default:
                    Console.WriteLine("Nepoznat izbor. Molim unesite broj od 1 do 6.");
                    break;
            }
        }
    }
}

// Ovaj program koristi dvije klase: Knjiga i Knjiznica.
// Klasa Knjiga predstavlja jednu knjigu i sadrži tri svojstva:
// Naslov, Autor i GodinaIzdanja.
// Klasa Knjiznica predstavlja knjižnicu i sadrži listu knjiga.
// Metoda DodajKnjigu dodaje knjigu u knjižnicu,
// metoda PretraziKnjige pretražuje knjige po naslovu ili autoru,
// metoda IspisiKnjige ispisuje sve knjige u knjižnici,
// a metoda ObrisiKnjigu briše knjigu iz knjižnice.
//
// U glavnom programu koristimo petlju while kako bismo omogućili
// korisniku da odabere jednu od ponuđenih opcija.
// Ovisno o odabiru korisnika, pozivamo odgovarajuću metodu klase Knjiznica.