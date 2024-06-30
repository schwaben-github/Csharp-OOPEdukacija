
    Console.Write("Unesite putanju: ");
    string putanja = Console.ReadLine();

    if (Directory.Exists(putanja))
    {
        Console.WriteLine("Direktorij postoji");
    }
    else
    {
        Console.WriteLine("Direktorij ne postoji");
        return;
    }

    string[] poddirektoriji = Directory.GetDirectories(putanja);
    string[] datoteke = Directory.GetFiles(putanja);
try
{
    Console.WriteLine("--------------------------------");
    foreach (string item in poddirektoriji)
    {
        DirectoryInfo dir = new DirectoryInfo(item);
        Console.WriteLine("Direktorij unutar putanje: {0}", dir.Name);
        Console.WriteLine("Sadrži {0} datoteka.", dir.GetFiles().Length);
        Console.WriteLine("Sadrži {0} poddirektorij(a).", dir.GetDirectories().Length);
    }
}
catch (Exception e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Greska: " + e.Message);
    Console.ResetColor();
}
finally
{
    Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
}