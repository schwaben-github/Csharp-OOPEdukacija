// Napiši program koji traži unos rečenice i zatim broji koliko puta se pojavjuje koja riječ iz te 
// rečenice.Program treba ignorirati velika i mala slova.

Console.Write("Unesi rečenicu: ");
string recenica = Console.ReadLine().ToLower();

string[] rijeci = recenica.Trim('.', ',', '!', '?').ToLower().Split(' ');

Dictionary<string, int> brojac = new Dictionary<string, int>();

foreach (string rijec in rijeci)
{
    if (brojac.ContainsKey(rijec))
    {
        brojac[rijec]++;
    }
    else
    {
        brojac.Add(rijec, 1);
    }
}

foreach (var item in brojac)
{
    Console.WriteLine($"Riječ {item.Key} se pojavljuje {item.Value} puta.");
}