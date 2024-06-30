// Napišite program koji unosi niz brojeva
// i ispisuje prosječnu vrijednost elemenata niza.
//
// Dodatne napomene:
// Provjerite ispravnost unesenih brojeva.
// Koristite for petlju za unos elemenata niza.
// Koristite varijablu za zbrajanje elemenata niza
// i varijablu za brojanje elemenata niza.


while (true)
{
    Console.Write("Unesi broj elemenata niza : ");
    int n;

    while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
    {
        Console.WriteLine("Neispravan unos. Unesi pozitivan cijeli broj za broj elemenata niza:");
        Console.Write("Unesite broj elemenata niza: ");
    }

    int[] niz = new int[n];

    for (int i = 0; i < n; i++)
    {
        Console.Write($"Unesi {i + 1}. element niza: ");
        while (!int.TryParse(Console.ReadLine(), out niz[i]))
        {
            Console.WriteLine("Neispravan unos. Molimo unesite cijeli broj:");
            Console.Write($"Unesite {i + 1}. element niza: ");
        }
    }

    double prosjek = 0;

    for (int i = 0; i < niz.Length; i++)
    {
        prosjek += niz[i];
    }

    prosjek /= niz.Length;
    Console.WriteLine($"Prosjek elemenata niza je: {prosjek:F2}"); // F2 za formatiranje na 2 decimalna mjesta

    Console.WriteLine("Želite li izračunati prosjek još jednog niza? (y/n): ");
    string odgovor = Console.ReadLine().ToLower();
    if (odgovor != "y")
    {
        break; // Izlazak iz petlje i završetak programa
    }
}