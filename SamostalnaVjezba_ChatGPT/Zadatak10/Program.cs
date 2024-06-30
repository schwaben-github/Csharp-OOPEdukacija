// Napišite program koji unosi broj n i ispisuje sve brojeve od 1 do n,
// ali preskače parne brojeve.
//
// Dodatne napomene:
// Koristite for petlju za iteraciju od 1 do n.
// Provjerite je li broj paran (% 2 == 0) i preskočite ga ako jest.
// Ispisujte samo neparne brojeve.

Console.Write("Unesite broj n: ");
int n = int.Parse(Console.ReadLine());

List<int> neparniBrojevi = new List<int>();

// Provjera da li je n negativno
if (n < 0)
{
    // Ispis neparnih brojeva od n do 1 u obrnutom redoslijedu
    for (int i = n; i <= 1; i++)
    {
        if (Math.Abs(i) % 2 == 1) // Provjera je li broj neparan (absolutna vrijednost)
        {
            neparniBrojevi.Add(i); // Dodavanje neparnog broja u listu
        }
    }
}
else
{
    // Ispis neparnih brojeva od 1 do n u obrnutom redoslijedu
    for (int i = n; i >= 1; i--)
    {
        if (i % 2 == 1)
        {
            neparniBrojevi.Add(i); // Dodavanje neparnog broja u listu
        }
    }
}

// Ispis neparnih brojeva
for (int i = neparniBrojevi.Count - 1; i >= 0; i--)
{
    Console.WriteLine(neparniBrojevi[i]);
}