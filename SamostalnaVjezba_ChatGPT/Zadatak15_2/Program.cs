// Traži se program koji će ispisati sve perfektne brojeve između 1 i 10000. Perfektni broj je broj koji je jednak sumi svojih djelitelja (bez njega samog).
// Program treba imati metodu koja će uzeti jedan ulazni argument: broj. Metoda treba vratiti true ako je broj perfektan, inače false.
// U glavnom programu, koristimo petlju for koja prolazi kroz brojeve od 1 do 10000.

for (int broj = 1; broj <= 10000; broj++)
{
    if (PerfektanBroj(broj))
    {
        Console.WriteLine($"{broj} je perfektan broj.");
    }
}

static bool PerfektanBroj(int broj)
{
    int suma = 0;

    for (int i = 1; i < broj; i++)
    {
        if (broj % i == 0)
        {
            suma += i;
        }
    }

    return suma == broj;
}