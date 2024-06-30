// Napiši program koji će tražiti unos broja ocjena od korisnika
// te će zatim izračunati i ispisati prosjek tih ocjena.
// Ocjene mogu biti realni brojevi.

Console.Write("Unesite broj predmeta: ");
int brojPredmeta;


while (!int.TryParse(Console.ReadLine(), out brojPredmeta) || brojPredmeta <= 0)
{
    Console.WriteLine("Neispravan unos. Molimo unesite pozitivan broj za broj predmeta:");
    Console.Write("Unesite broj predmeta: ");
}

var ocjene = new List<double>();

for (int i = 1; i <= brojPredmeta; i++)
{
    Console.Write($"Unos ocjene za predmet broj {i}: ");

    string unos = Console.ReadLine();

    if (double.TryParse(unos, out double ocjena))
    {
        if (ocjena >= 1 && ocjena <= 5)
        {
            ocjene.Add(ocjena);
        }
        else
        {
            Console.WriteLine("Molim unesite ocjenu između 1 i 5.");
        }
    }
    else
    {
        Console.WriteLine("Neispravan unos. Molimo unesite broj.");
    }
}

double prosjek = 0;
if (ocjene.Count > 0)
{
    double zbrojOcjena = 0;
    foreach (var ocjena in ocjene)
    {
        zbrojOcjena += ocjena;
    } 

    prosjek = zbrojOcjena / ocjene.Count;
}

Console.WriteLine();
Console.Write($"Prosjek ocjena za {brojPredmeta} predmeta je: {prosjek:F2}");
