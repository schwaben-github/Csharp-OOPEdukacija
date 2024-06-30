// U glavnom programu kreiraj objekt klase Zaposlenik, traži od korisnika unos polja i zatim ispiši BrutoPlaca.
// Program osiguraj od grešaka.

using ZaposlenikApp;

Zaposlenik zaposlenik = new Zaposlenik();
try
{
    Console.Write("Unesite ime zaposlenika: ");
    zaposlenik.Ime = Console.ReadLine();
    Console.Write("Unesite prezime zaposlenika: ");
    zaposlenik.Prezime = Console.ReadLine();
    Console.Write("Unesite OIB zaposlenika: ");
    zaposlenik.OIB = Console.ReadLine();
    Console.Write("Unesite broj bodova zaposlenika: ");
    zaposlenik.BrojBodova = Math.Abs(int.Parse(Console.ReadLine()));
    if (zaposlenik.BrojBodova <= 0)
    {
        throw new Exception("Broj bodova mora biti veći od nule!");
    }
    Console.Write("Unesite vrijednost boda zaposlenika: ");
    zaposlenik.VrijednostBoda = double.Parse(Console.ReadLine());
    if (zaposlenik.VrijednostBoda <= 0)
    {
        throw new Exception("Vrijednos boda mora biti veća od nule!");
    }

    Console.WriteLine("Bruto plaća zaposlenika {0} {1} je {2}.", zaposlenik.Ime, zaposlenik.Prezime, zaposlenik.BrutoPlaca());
}
catch (Exception e)
{
    Console.WriteLine("Greška: " + e.Message);
}
