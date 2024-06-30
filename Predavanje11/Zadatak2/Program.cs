﻿// Napravi program koji traži unos prirodnog broja sve dok se ne upiše 0.
// Program ispisuje koji je najmanji, a koji najveći od unesenih brojeva.

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

if (brojevi.Any())
{
    int min = brojevi.Min();
    int max = brojevi.Max();
    Console.WriteLine($"Najmanji uneseni broj je {min}.");
    Console.WriteLine($"Najveći uneseni broj je {max}.");
}
else
{
    Console.WriteLine("Nisi unio niti jedan prirodan broj!");
}