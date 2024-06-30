// Napiši program koji će provjeriti je li uneseni broj prost broj ili ne.
// Prost broj je broj veći od 1 koji nije djeljiv ni s jednim brojem osim s 1 i samim sobom.

Console.Write("Unesi broj: ");
int broj;

while (!int.TryParse(Console.ReadLine(), out broj))
{
    Console.Write("Neispravan unos. Molimo unesite cijeli broj!");
}

bool prost = true;

if (broj <= 1)
{
    prost = false;
}
else
{
    for (int i = 2; i <= Math.Sqrt(broj); i++)
    {
        if (broj % i == 0)
        {
            prost = false;
            break;
        }
    }
}

if (prost)
{
    Console.WriteLine("Uneseni broj je prost.");
}
else
{
    Console.WriteLine("Uneseni broj nije prost.");
}