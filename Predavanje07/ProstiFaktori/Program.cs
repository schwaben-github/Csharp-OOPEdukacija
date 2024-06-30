
try
{
    Console.Write("Unesi prirodni broj: ");
    int iUnos;
    string sUnos;

    sUnos = Console.ReadLine();
    iUnos = int.Parse(sUnos);
    if (iUnos <= 0)
    {
        throw new Exception("Broj nije prirodan.");
    }

    List<int> faktori = new List<int>();
    int faktor = 2;

    while (iUnos != 1 && faktor <= iUnos)
    {
        if (iUnos % faktor == 0)
        {
            iUnos = iUnos / faktor;
            faktori.Add(faktor);
        }
        else
        {
            faktor++;
        }
    }

    // 1. način
    int counter = 0;
    foreach (int item in faktori)
    {
        Console.Write(item);
        if (counter != faktori.Count - 1)
        {
            Console.Write("*");
        }
        counter++;
    }

    Console.WriteLine();
    Console.WriteLine("------------------------------------------");

    // 2. način
    string rezultat = String.Join("*", faktori);
    Console.Write(rezultat);

}
catch (Exception e)
{
    Console.WriteLine("Greška! Detalji: " + e.Message);
}