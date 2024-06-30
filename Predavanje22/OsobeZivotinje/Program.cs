using OsobeZivotinje;
using System.Collections;

Osoba osoba1 = new Osoba();
osoba1.Ime = "Pero";
osoba1.Prezime = "Perić";
System.Console.WriteLine(osoba1.PunoIme());

Osoba osoba2 = osoba1;
osoba2.Ime = "Ana";

Console.WriteLine(osoba1.Ime);
Console.WriteLine(ReferenceEquals(osoba1, osoba2));


// Nova osoba preko metode Clone
Osoba osoba3 = (Osoba)osoba1.Clone();
osoba3.Ime = "Ivana";
Console.WriteLine(osoba1.Ime);
Console.WriteLine(object.ReferenceEquals(osoba1, osoba3));

// Svojstvo Partner
osoba1.Partner = osoba3;
Console.WriteLine(osoba1.Ime + ", Partner: " + osoba1.Partner.Ime);
Console.WriteLine(ReferenceEquals(osoba3, osoba1.Partner));

osoba3.Partner = osoba1;
Console.WriteLine(osoba3.Ime + ", Partner: " + osoba3.Partner.Ime);

/*// Metoda Dispose
IDisposable dis = osoba1;
dis.Dispose();
Console.WriteLine(osoba1.Partner.Ime);*/

// Primjer koristenja interfejsa ImojInterface

Zivotinja zivotinja1 = new Zivotinja();
zivotinja1.NarodniNaziv = "Vuk";
zivotinja1.LatinskiNaziv = "Canis lupus";
Console.WriteLine(zivotinja1.PunoIme());

Zivotinja zivotinja2 = new Zivotinja();
zivotinja2.NarodniNaziv = "Medvjed";
zivotinja2.LatinskiNaziv = "Ursus arctos";
Console.WriteLine(zivotinja2.PunoIme());

ArrayList lista = new ArrayList();
lista.Add(osoba1);
lista.Add(osoba2);
lista.Add(osoba3);
lista.Add(zivotinja1);
lista.Add(zivotinja2);

foreach (ImojInterface item in lista)
{
    Console.WriteLine(item.PunoIme());
}