using OsobaApp;

Osoba o = new Osoba();

o.Ime = "iVan mArko";
o.Prezime = "Ivić Aničić";

o.Pozdrav();
Console.WriteLine("Vaši inicijali su: " + o.Inicijali());
Console.WriteLine(o.Kapitalizacija());