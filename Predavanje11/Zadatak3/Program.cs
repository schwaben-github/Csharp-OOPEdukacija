// Napravi program koji traži unos 10 brojeva.
// Program ispisuje koliko je uneseno brojeva djeljivih sa 3 i koliki je njihov umnožak.

int[] brojevi = new int[10];

for (int i = 0; i < 10; i++)
{
    bool ispravanUnos;
    do
    {
        Console.Write("Unesi {0}. broj: ", i + 1);
        string unos = Console.ReadLine();

        ispravanUnos = int.TryParse(unos, out brojevi[i]);

        if (!ispravanUnos)
        {
            Console.WriteLine("Neispravan unos. Molim samo brokeve!");
        }
    } while (!ispravanUnos);
}

int brojac = 0;
int umnozak = 1;

foreach (int broj in brojevi)
{
    if (broj % 3 == 0 && broj != 0)
    {
        brojac++;
        umnozak *= broj;
    }
}

Console.WriteLine("Broj unesenih brojeva djeljivih sa 3: " + brojac);
if (brojac > 0)
{
	Console.WriteLine("Umnožak unesenih brojeva djeljivih sa 3: " + umnozak);
}
else
{
	Console.WriteLine("Umnožak nema smisla, jer niti jedan broj nije djeljiv sa 3!");
}