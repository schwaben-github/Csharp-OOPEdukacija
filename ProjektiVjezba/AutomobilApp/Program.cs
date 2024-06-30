// Napravi klasu Automobil koja ima svojstva: Marka(string), KS(double), OsnovnaCijena(double)
// i metode: IznosPoreza() koja vraća iznos poreza (5% ako je KS <= 50, 10 % ako je 50 < KS <= 150, 15% ako je KS > 150)
// i UkupnaCijena() koja vraća cijenu automobila s porezom (OsnovnaCijena + IznosPoreza).
//
// U glavnom programu kreiraj objekt klase Automobil,
// traži od korisnika unos polja i zatim ispiši UkupnaCijena.
// Program osiguraj od grešaka.

using AutomobilApp;

Automobil automobil = new Automobil();
try
{
    Console.Write("Unesite marku automobila: ");
    automobil.Marka = Console.ReadLine();
    Console.Write("Unesite KS automobila: ");
    automobil.KS = double.Parse(Console.ReadLine());
    Console.Write("Unesite osnovnu cijenu automobila: ");
    automobil.OsnovnaCijena = double.Parse(Console.ReadLine());

    Console.WriteLine("Ukupna cijena automobila {0} je {1}.", automobil.Marka, automobil.UkupnaCijena());
}
catch (Exception e)
{
    Console.WriteLine("Greška: " + e.Message);
}
