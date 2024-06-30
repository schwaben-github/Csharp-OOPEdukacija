using Interfejsi3;

Osoba o = new Osoba();
o.Ime = "Pero";
o.Prezime = "Perić";
o.Starost = 22;

Console.WriteLine(o.Detalji());
Console.WriteLine("----------------------");

Osoba o3 = o;
o3.Ime = "Janko";
Console.WriteLine(o.Detalji());
Console.WriteLine(o3.Detalji());
Console.WriteLine("----------------------");

Osoba o2 = (Osoba)o.Clone();
o2.Ime = "Marko";
Console.WriteLine(o.Detalji());
Console.WriteLine(o2.Detalji());
Console.WriteLine("----------------------");

if (o == o2)
    Console.WriteLine("o = o2");
else
    Console.WriteLine("o != o2");
Console.WriteLine("----------------------");

if (o.CompareTo(o2) == 0)
    Console.WriteLine("Objekti su isti.");
else if (o.CompareTo(o2) == 1)
    Console.WriteLine("Objekti nisu isti.");
else if (o.CompareTo(o2) == -1)
    Console.WriteLine("Objekti nisu isti.");