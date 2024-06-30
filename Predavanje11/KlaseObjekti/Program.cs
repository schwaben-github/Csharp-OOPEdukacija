// Instanciranje klase Osoba - kreiranje objekta osoba, koji je tipa (vrste) klase Osoba
Osoba osoba = new Osoba();

osoba.Ime = "Pero";
osoba.Prezime = "Perić";

string punoImeOsobe = osoba.VratiPunoIme();

Console.WriteLine("Puno ime instancirane osobe je {0}.", punoImeOsobe);

// Instanciranje klase Osoba sa vrijednostima svojstava
Osoba osoba2 = new Osoba()
{
    Ime = "Ivo",
    Prezime = "Ivić"
};

Console.WriteLine("Puno ime druge instancirane osobe je {0}.", osoba2.VratiPunoIme());

// Instanciranje klase Osoba sa unsosom svojstava
Osoba osoba3 = new Osoba();
Console.Write("Unesi ime: ");
osoba3.Ime = Console.ReadLine();
Console.Write("Unesi prezime: ");
osoba3.Prezime = Console.ReadLine();

Console.WriteLine("Puno ime treće osobe je: " + osoba3.VratiPunoIme());

// Definicija klase Osoba
// Vrste objekata iz realnog svijeta: Klase
class Osoba
{
    // Definicija svojstava klase
    public string Ime { get; set; }

    public string Prezime { get; set; }

    // Definicija metoda klase
    public string VratiPunoIme()
    {
        return $"{Ime} {Prezime}";
    }
}