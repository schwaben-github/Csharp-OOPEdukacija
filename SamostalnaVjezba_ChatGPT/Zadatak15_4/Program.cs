// Traži se program koji će ispitati jesu li dva broja prijateljski brojevi.
// Prijateljski brojevi su dva broja čija je suma pravih djelitelja prvog broja jednaka drugom broju, a suma pravih djelitelja drugog broja jednaka prvom broju.
// Program treba tražiti unos dva broja i prvo ispisati sve djelitelje oba broja te njihove sume, a nakon toga ispisati jesu li brojevi prijateljski.
// Program treba imati metodu koja će uzeti dva ulazna argumenta: broj1 i broj2. Metoda treba vratiti true ako su brojevi prijateljski, inače false.

Console.Write("Unesi prvi broj: ");
int broj1 = int.Parse(Console.ReadLine());

Console.Write("Unesi drugi broj: ");
int broj2 = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Djelitelji broja {broj1} su :");
for (int i = 1; i < broj1; i++)
{
    if (broj1 % i == 0)
    {
        Console.Write(i + " ");
    }
}

Console.WriteLine($"\nDjelitelji broja {broj2} su :");
for (int i = 1; i < broj2; i++)
{
    if (broj2 % i == 0)
    {
        Console.Write(i + " ");
    }
}

Console.WriteLine();
Console.WriteLine("-----------------------------");
Console.WriteLine();
bool rezultat = PrijateljskiBrojevi(broj1, broj2);

if (rezultat)
{
    Console.WriteLine($"{broj1} i {broj2} su prijateljski brojevi.");
}
else
{
    Console.WriteLine($"{broj1} i {broj2} nisu prijateljski brojevi.");
}

static bool PrijateljskiBrojevi(int broj1, int broj2)
{
    int suma1 = 0;
    int suma2 = 0;

    for (int i = 1; i < broj1; i++)
    {
        if (broj1 % i == 0)
        {
            suma1 += i;
        }
    }

    for (int i = 1; i < broj2; i++)
    {
        if (broj2 % i == 0)
        {
            suma2 += i;
        }
    }

    return suma1 == broj2 && suma2 == broj1;
}