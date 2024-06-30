// Napiši program koji će tražiti unos duljine i niza brojeva od korisnika
// te izračunati umnožak svih elemenata tog niza.

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

int umnozak = 1;

foreach (int broj in niz)
{
    umnozak *= broj;
}

Console.WriteLine($"Konačni umnožak: {umnozak}");