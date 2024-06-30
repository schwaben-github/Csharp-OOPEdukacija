// Tražimo unos
Console.Write("Unesi riječ: ");
string rijec = Console.ReadLine();

// Tražimo unos znaka
Console.Write("Unesi znak: ");
char znak = Console.ReadKey().KeyChar;

// Razmak između unosa
Console.WriteLine();

// Brojimo pojavljivanje znaka u riječi
int brojac = 0;
for (int i = 0; i < rijec.Length; i++)
{
    if (rijec[i] == znak)
    {
        brojac++;
    }
}

// Ispisujemo rezultat
Console.WriteLine($"Znak {znak} se pojavljuje {brojac} puta u riječi {rijec}.");