using System;

List<int> brojevi = new List<int>();
int broj = -1;

do
{
    Console.Write("Unesi prirodan broj (0 za kraj): ");
    try
    {
        broj = int.Parse(Console.ReadLine());
        if (broj < 0)
        {
            throw new Exception("Uneseni broj nije prirodan!");
        }
        else if (broj != 0)
        {
            brojevi.Add(broj);
        }

    }
    catch (Exception e)
    {
        Console.WriteLine("Greška: " + e.Message);
    }
} while (broj != 0);

brojevi.Sort();
brojevi.Reverse();

Console.WriteLine("Sortirani brojevi:");
foreach (int b in brojevi)
{
    Console.WriteLine(b);
}