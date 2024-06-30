// Napiši program koji će tražiti unos niza brojeva od korisnika
// te će zatim pronaći i ispisati najveći broj u tom nizu.

List<int> brojevi = new List<int>();
int broj;

do
{
    Console.Write("Unesi prirodne brojeve (0 za kraj): ");
    string unos = Console.ReadLine();

    if (!int.TryParse(unos, out broj))
    {
        Console.WriteLine("Neispravan unos!");
        continue;
    }

    if (broj < 0)
    {
        Console.WriteLine("Broj nije prirodan!");
        continue;
    }

    if (broj != 0)
    {
        brojevi.Add(broj);
    }

} while (broj != 0);

int najveciBroj = brojevi[0];
foreach(var clan in brojevi)
{
    if (clan > najveciBroj)
    {
        najveciBroj = clan;
    }
}

Console.Write("Najveći uneseni broj je: " + najveciBroj);