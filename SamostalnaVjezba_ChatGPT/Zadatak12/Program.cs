// Napiši program koji traži od korisnika da unese niz cijelih brojeva.
// Program zatim treba izračunati sumu svih parnih brojeva u nizu i sumu
// svih neparnih brojeva u nizu. Na kraju, program treba ispisati oba rezultata.

// Unos duljine niza
Console.Write("Unesi broj elemenata niza : ");
int n;

// Provjera ispravnosti unosa duljine niza
while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
{
    Console.WriteLine("Neispravan unos. Unesi pozitivan cijeli broj za broj elemenata niza:");
    Console.Write("Unesite broj elemenata niza: ");
}

// Inicijalizacija niza
int[] niz = new int[n];

// Unos elemenata niza
for (int i = 0; i < n; i++)
{
    Console.Write($"Unesi {i + 1}. element niza: ");
    while (!int.TryParse(Console.ReadLine(), out niz[i]))
    {
        Console.WriteLine("Neispravan unos. Molimo unesite cijeli broj:");
        Console.Write($"Unesite {i + 1}. element niza: ");
    }
}

// Inicijalizacija varijabli i poziv funkcija za izračun sume parnih i neparnih brojeva
int sumaParnih = SumaParnihBrojeva(niz);
int sumaNeparnih = SumaNeparnihBrojeva(niz);

// Ispis rezultata
Console.WriteLine($"Suma parnih brojeva u nizu je: {sumaParnih}");
Console.WriteLine($"Suma neparnih brojeva u nizu je: {sumaNeparnih}");

// Funkcije za izračun sume parnih i neparnih brojeva
static int SumaParnihBrojeva(int[] niz)
{
    int sumaParnih = 0;
    foreach (int broj in niz)
    {
        if (broj % 2 == 0)
        {
            sumaParnih += broj;
        }
    }
    return sumaParnih;
}
// Funkcije za izračun sume parnih i neparnih brojeva
static int SumaNeparnihBrojeva(int[] niz)
{
    int sumaNeparnih = 0;
    foreach (int broj in niz)
    {
        if (broj % 2 != 0)
        {
            sumaNeparnih += broj;
        }
    }
    return sumaNeparnih;
}