using System;
using System.Collections;

using OsobaApp;

Osoba o = new Osoba();

o.Ime = "Ivan";
o.Prezime = "Ivić";

o.Pozdrav(o.Ime);
Console.WriteLine("Vaši inicijali su: " + o.Inicijali(o.Ime) + o.Inicijali(o.Prezime));
Console.WriteLine(o.Kapitalizacija(o.Ime) + o.Kapitalizacija(o.Prezime));
