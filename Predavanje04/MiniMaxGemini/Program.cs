int[] brojevi = new int[10];
int min = int.MaxValue;
int max = int.MinValue;

for (int i = 0; i < brojevi.Length; i++)
{
    Console.Write("Unesite {0}. broj: ", i + 1);
    brojevi[i] = int.Parse(Console.ReadLine());

    if (brojevi[i] < min)
    {
        min = brojevi[i];
    }

    if (brojevi[i] > max)
    {
        max = brojevi[i];
    }
}

Console.WriteLine("Najmanji broj: {0}", min);
Console.WriteLine("Najveći broj: {0}", max);