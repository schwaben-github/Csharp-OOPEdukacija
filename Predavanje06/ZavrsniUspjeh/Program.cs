int[] niz = new int[10];

// unos pomoću petlje
for (int i = 0; i < niz.Length; i++)
{
    Console.Write($"Unesi {i}. element niza: ");
    niz[i] = int.Parse(Console.ReadLine());
}

// ispis pomoću petlje
Console.WriteLine("=================== ispis ====================");
for (int i = 0; i < niz.Length; i++)
{
    Console.WriteLine(niz[i]);
}

// ispis pomoću foreach petlje
Console.WriteLine("================== foreach ===================");
foreach (int element in niz)
{
    Console.WriteLine(element);
}

// najveći element u nizu
Console.WriteLine("================== MinMax  ===================");
int max = int.MinValue;
foreach (int element in niz)
{
    if (element > max)
    {
        max = element;
    }
}
Console.WriteLine("Najveći broj je: " + max);

// ispisati minimum
Console.WriteLine("Najmanji broj u nizu je: " + niz.Min());
