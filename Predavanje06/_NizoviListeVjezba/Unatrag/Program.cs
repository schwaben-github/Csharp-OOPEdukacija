using System.Collections;

ArrayList lista = new ArrayList();

for (int i = 0; i < 10; i++)
{
    bool bOk = false;
    while (!bOk)
    {
        Console.Write($"Unesi {i + 1}. element: ");
        try
        {
            string unos = Console.ReadLine();
            lista.Add(unos);
            bOk = true;
        }
        catch (Exception)
        {
            Console.WriteLine("Dogodila se greška. Ponovi unos.");
        }
    }
}

Console.WriteLine("\nIspis unatrag:");
for (int i = lista.Count - 1; i >= 0; i--)
{
    Console.WriteLine(lista[i]);
}
