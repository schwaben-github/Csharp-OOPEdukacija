using Konstruktori;

Osoba o1 = new Osoba();
o1.Ime = "Ivan";
o1.Prezime = "Ivanović";
Console.WriteLine("Ime: {0} Prezime:{1}", o1.Ime, o1.Prezime);

Osoba o2 = new Osoba("Josip", "Josipović");
Console.WriteLine("Ime: {0} Prezime:{1}", o2.Ime, o2.Prezime);

Osoba o3 = new Osoba("Ana", false);
Console.WriteLine("Ime: {0} Prezime:{1}", o3.Ime, o3.Prezime);

Osoba o4 = new Osoba("Anić", true);
Console.WriteLine("Ime: {0} Prezime:{1}", o4.Ime, o4.Prezime);


List<Osoba> lstOsobe = new List<Osoba>();
    lstOsobe.Add(o1);
    lstOsobe.Add(o2);
    lstOsobe.Add(o3);
    lstOsobe.Add(o4);

// Ekvivalentno: lstOsobe = [o1, o2, o3, o4];

Console.WriteLine("------------------------");
foreach (Osoba o in lstOsobe)
{
    Console.WriteLine("Ime: {0} Prezime:{1}", o.Ime, o.Prezime);
}