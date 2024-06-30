// Mersenov broj je broj oblika 2^n - 1, gdje je n prost broj. Traži se program koji će ispisati sve mersenove brojeve do n = 257.
// Program treba imati metodu koja će uzeti jedan ulazni argument: broj. Metoda treba vratiti true ako je broj Mersenov broj, inače false.
// U glavnom programu, koristimo petlju for koja prolazi kroz proste brojeve do 11.


for (int i = 2; i <= 257; i++)
{
    if (JeProst(i))
    {
        int mersenovBroj = (int)Math.Pow(2, i) - 1;
        if (JeMersenov(mersenovBroj))
        {
            Console.WriteLine(mersenovBroj);
        }
    }
}

static bool JeProst(int broj)
{
    if (broj <= 1) return false;
    for (int i = 2; i < broj; i++)
    {
        if (broj % i == 0) return false;
    }
    return true;
}

static bool JeMersenov(int broj)
{
    for (int i = 2; i <= Math.Sqrt(broj); i++)
    {
        if (broj == Math.Pow(2, i) - 1)
        {
            return true;
        }
    }
    return false;
}