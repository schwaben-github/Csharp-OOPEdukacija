using DataAccessLayer;
using System.Collections;

Polaznik p1 = new Polaznik();
p1.Ime = "Pero";
p1.Prezime = "Perić";
p1.ProgramObrazovanja = "ASP.NET";

Polaznik p2 = new Polaznik();
p2.Ime = "Ana";
p2.Prezime = "Anić";
p2.ProgramObrazovanja = "Web design";

//1. ArrayList
ArrayList alPolaznici = new ArrayList();
alPolaznici.Add(p1);
alPolaznici.Add(p2);
foreach (Polaznik p in alPolaznici)
{
    Console.WriteLine(p.PunoIme());
}
Console.WriteLine("---------drugi način-----------");
for (int i = 0; i < alPolaznici.Count; i++)
{
    Console.WriteLine(alPolaznici[i].ToString());
}
Console.WriteLine("-------------Proizvoljna kolekcija----------------");
//2. Polaznici
Polaznici polaznici = new Polaznici();
polaznici.Add(p1);
polaznici.Add(p2);

//Alternativa: Polaznici polaznici = [p1, p2];

foreach (Polaznik p in polaznici)
{
    Console.WriteLine(p.ToString());
}