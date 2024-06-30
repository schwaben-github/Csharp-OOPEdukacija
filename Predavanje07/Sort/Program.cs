try
{
    int[] sortirajMe = new int[100];
    int brojUnosa = 0;

    // Unos brojeva
    Console.WriteLine("Unesi prirodne brojeve. Unesi 0 za kraj. ");
    while (true)
    {
        Console.Write("Unesi broj: ");
        string stoToStavljasUNos = Console.ReadLine();

        if (stoToStavljasUNos == "0")
            break;

        if (!int.TryParse(stoToStavljasUNos, out int unos))
        {
            Console.WriteLine("Neispravan format broja... Pokušaj još jednom.");
            continue;
        }

        sortirajMe[brojUnosa] = unos;
        brojUnosa++;
    }

    Array.Sort(sortirajMe, 0, brojUnosa);

    // Ispis
    Console.WriteLine("\nSortirani brojevi: ");
    foreach (int broj in sortirajMe)
    {
        if (broj != 0)
            Console.Write(broj + " ");
    }
    Console.WriteLine();
}
catch (OverflowException)
{
    Console.WriteLine("Unio si više od 100 brojeva!? Kako ti je to uspjelo???");
}
catch (Exception ex)
{
    Console.WriteLine("Došlo je do greške: " + ex.Message);
}
finally
{
    Console.WriteLine("This is the end...");
    Console.ReadKey();
}