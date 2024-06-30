// Napiši program koji će tražiti unos broja od korisnika
// te provjeriti je li taj broj paran ili neparan.
// Ispiši odgovarajuću poruku.

Console.Write("Unesi broj za provjeru: ");
string unos = Console.ReadLine();

int broj;
if (int.TryParse(unos, out broj))
{
	if (broj % 2 == 0)
	{
        Console.WriteLine($"Uneseni broj {broj} je paran.");
    }
	else
	{
        Console.WriteLine($"Uneseni broj {broj} je neparan.");
    }
}
else
{
    Console.Write("Nisi unio ispravan broj!");
}