try
{
    Console.Write("Unesite putanju: ");
    string putanja = Console.ReadLine();

    string[] poddirektoriji = Directory.GetDirectories(putanja);

    Console.WriteLine();
    Console.WriteLine("---------- Poddirektoriji ----------");
    foreach (string item in poddirektoriji)
    {
        Console.WriteLine(item);
    }
}
catch (Exception e)
{
    Console.WriteLine("Greska: " + e.Message);
}


// Varijanta sa IEnumerable<string> i Directory.EnumerateDirectories
/*try
{
    Console.Write("Unesite putanju: ");
    string putanja = Console.ReadLine();

    IEnumerable<string> listOfDirectories = Directory.EnumerateDirectories(putanja);

    Console.WriteLine();
    Console.WriteLine("---------- Poddirektoriji ----------");
    foreach (var dir in listOfDirectories)
    {
        Console.WriteLine(dir);
    }
}
catch (Exception e)
{
    Console.WriteLine("Greska: " + e.Message);
}*/