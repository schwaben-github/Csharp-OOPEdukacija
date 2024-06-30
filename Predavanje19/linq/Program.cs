// LINQ -> Language Integrated Query
// LINQ is a set of extensions to the .NET Framework that encompass language-integrated query, set, and transform operations.
// It extends C# and Visual Basic with native language syntax for queries and provides class libraries to take advantage of these capabilities.

using linq;

List<Osoba> osobe = new List<Osoba>();
osobe.Add(new Osoba { Ime = "Ana", Prezime = "Anić" });
osobe.Add(new Osoba { Ime = "Pero", Prezime = "Perić" });
osobe.Add(new Osoba { Ime = "Slavko", Prezime = "Slavković" });
osobe.Add(new Osoba { Ime = "Marko", Prezime = "Marković" });
osobe.Add(new Osoba { Ime = "Ante", Prezime = "Antolović" });
osobe.Add(new Osoba { Ime = "Ana", Prezime = "Ivanović" });

//klasični način pretraživanja liste
Osoba trazenaOsoba = new Osoba();
foreach (Osoba os in osobe)
{
    if (os.Ime == "Ana")
    {
        trazenaOsoba = os;
        //break;
    }
}
Console.WriteLine("{0} {1}", trazenaOsoba.Ime, trazenaOsoba.Prezime);


//SIntaksa upita - LINQ pretraga
trazenaOsoba = (from os in osobe
                where os.Ime == "Pero"
                select os).SingleOrDefault();
Console.WriteLine("{0} {1}", trazenaOsoba.Ime, trazenaOsoba.Prezime);


trazenaOsoba = (from os in osobe
                where os.Ime == "Ana"
                select os).FirstOrDefault();
Console.WriteLine("{0} {1}", trazenaOsoba.Ime, trazenaOsoba.Prezime);


Console.Write("Unesi pojam u imenu osobe za pretragu: ");
string upit = Console.ReadLine();
List<Osoba> trazeneOsobe = (from os in osobe
                            orderby os.Ime descending
                            where os.Ime.ToLower().Contains(upit.ToLower())
                            select os).ToList();
foreach (var item in trazeneOsobe)
{
    Console.WriteLine("{0} {1}", item.Ime, item.Prezime);
}