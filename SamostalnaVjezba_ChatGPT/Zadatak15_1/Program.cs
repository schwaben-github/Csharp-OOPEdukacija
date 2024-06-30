// Da bismo pronašli Armstrongove brojeve između 1 i 10000, možemo iskoristiti vašu implementiranu metodu ArmstrongovBroj.
// U glavnom programu, koristimo petlju for koja prolazi kroz brojeve od 1 do 1000.
// Ako je trenutni broj Armstrongov broj, ispisujemo ga.

for (int broj = 1; broj <= 10000; broj++)
{
    if (ArmstrongovBroj(broj))
    {
        Console.WriteLine($"{broj} je Armstrongov broj.");
    }
}
static bool ArmstrongovBroj(int broj)
{
    int originalniBroj = broj;
    int suma = 0;
    int duljina = broj.ToString().Length;

    while (broj > 0)
    {
        int znamenka = broj % 10;
        suma += (int)Math.Pow(znamenka, duljina);
        broj /= 10;
    }

    return suma == originalniBroj;
}