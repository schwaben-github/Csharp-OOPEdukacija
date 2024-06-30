// Napišite program koji će provjeriti je li zadani broj Armstrongov broj. Armstrongov broj je broj koji je jednak sumi n-tih potencija svojih znamenki.
// Na primjer, 153 je Armstrongov broj jer je 1^3 + 5^3 + 3^3 = 153.
// Program treba tražiti unos broja i ispisati je li broj Armstrongov broj.
// Program treba imati metodu koja će uzeti jedan ulazni argument: broj. Metoda treba vratiti true ako je broj Armstrongov broj, inače false.

Console.Write("Unesi broj za provjeru: ");
int unos = int.Parse(Console.ReadLine());

bool rezultat = ArmstrongovBroj(unos);

if (rezultat)
{
    Console.WriteLine($"{unos} je Armstrongov broj.");
}
else
{
    Console.WriteLine($"{unos} nije Armstrongov broj.");
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