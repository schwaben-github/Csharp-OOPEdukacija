// Napiši program u kojem se traži unos prirodnog broja n.
// Korisnik zaƟm unosi n prirodnih brojeva, a zaƟm se ispisuje njihov prosjek.

try
{
	Console.Write("Sa koliko vrijednosti računamo prosjek? ");
	int n = int.Parse(Console.ReadLine());

	int[] brojevi = new int[n];
	int suma = 0;

	for (int i = 0; i < n; i++)
	{
		Console.Write("Unesite {0}. broj: ", i + 1);
		brojevi[i] = int.Parse(Console.ReadLine());
		suma += brojevi[i];
	}

	double prosjek = (double)suma / n;

	Console.WriteLine("Prosjek: {0}", prosjek);
}
catch (Exception ex)
{
    Console.WriteLine("Pogrešan unos! " + ex.Message);
}