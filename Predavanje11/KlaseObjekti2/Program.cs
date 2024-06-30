// Klasa: skup povezanog koda koji predstavlja neki objekat
// Koristi se kao nacrt za kreiranje objekata
// Objekat: instanca klase

Osoba o = new Osoba();
o.Ime = "Marko";
o.Prezime = "Marković";
Console.WriteLine(o.PunoIme());

Osoba o2 = new Osoba();
o2.Ime = "Ana";
o2.Prezime = "Anić";
Console.WriteLine(o2.PunoIme());
Console.WriteLine("Broj osoba:" + Osoba.DohvatiBrojOsoba());

Osoba o3 = new Osoba("Josip", "Josipović");
Console.WriteLine(o3.PunoIme());



class Osoba
{
    // Konstruktor klase Osoba
    // Ima isto ime kao i klasa
    // nema return type iako je metoda
    // može pristupati svim svojstvima, metodama i događajima iz klase
    public Osoba()
    {
        // svaki put kada se kreira novi objekt klase Osoba, povećava se broj osoba
        iBrojOsoba++;
    }

    // Ne-defaultni konstruktor klase
    public Osoba(string ime, string prezime)
    {
        this.Ime = ime;
        this.Prezime = prezime;
    }

    // Definicija svojstava klase - statičko svojstvo
    // private modifikator pristupa - pristup svojstvu je moguć samo unutar klase
    // ograničava pristup svojstvima/metodama/događajima izvana klase
    private static int iBrojOsoba = 0;

    public static int DohvatiBrojOsoba()
    {
        return iBrojOsoba;
    }

    // Definicija svojstava
    public string Ime { get; set; }
    public string Prezime { get; set;}

    // Definicija metode
    public string PunoIme()
    {
        return $"{Ime} {Prezime}";
    }
}
