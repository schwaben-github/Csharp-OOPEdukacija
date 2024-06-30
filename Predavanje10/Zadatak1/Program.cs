// Napravi program koji traži unos rečenice od korisnika, a zatim ispisuje
// koliko samoglasnika i koliko suglasnika rečenica sadrži.
// Program treba biti otporanna greške pri unosu.

int brojSamo = 0;
int brojSugla = 0;

Console.Write("Unesi rečenicu: ");
string recenica  = Console.ReadLine();

foreach (char slovo in recenica.ToLower())
{
	if (!Char.IsLetter(slovo))
	{
		continue;
	}
	else if (slovo == 'a' || slovo == 'e' || slovo == 'i' || slovo == 'o' || slovo == 'u')
	{
		brojSamo++;
	}
	else
	{
		brojSugla++;
	}
 }

Console.WriteLine($"Broj samoglasnika je: {brojSamo}");
Console.WriteLine($"Broj suglasnika je: {brojSugla}");