int[] brojevi = new int[10];

try
{
    for (int i = 0; i < brojevi.Length; i++)
    {
        Console.Write("Unesi {0}. broj: ", i + 1);
        brojevi[i] = int.Parse(Console.ReadLine());
    }
    // Ispis
    Console.WriteLine("Tvoji brojevi:");
    foreach (int broj in brojevi)
    {
        Console.Write(broj + " ");
    }
    Console.WriteLine();

    int minIndex = 0;
    int maxIndex = 0;
    for (int i = 1; i < brojevi.Length; i++)
    {
        if (brojevi[i] < brojevi[minIndex])
        {
            minIndex = i;
        }
        if (brojevi[i] > brojevi[maxIndex])
        {
            maxIndex = i;
        }
    }

    int temporary = brojevi[maxIndex];
    brojevi[maxIndex] = brojevi[minIndex];
    brojevi[minIndex] = temporary;

    Console.WriteLine("Ispred zagrade manje: ");
    foreach (int broj in brojevi)
    {
        Console.Write(broj + " ");
    }
    Console.WriteLine();
}
catch (Exception e)
{
    Console.WriteLine("Došlo je do pogreške: " + e.Message);
}
