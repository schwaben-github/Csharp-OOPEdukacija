Console.Write("Unesi path: ");
string path = Console.ReadLine();

if (Directory.Exists(path))
{
    Console.WriteLine("Direktorij postoji!");

    Console.WriteLine();
    Console.WriteLine("-------------- Poddirektoriji --------------");
    Console.WriteLine();
    string[] poddirektoriji = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
    foreach (string item in poddirektoriji)
    {
        Console.WriteLine("Path do direktorija: {0}.", item);
    }

    Console.WriteLine();
    Console.WriteLine("----------------- Datoteke -----------------");
    Console.WriteLine();
    string[] datoteke = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
    foreach (var item in datoteke)
    {
        Console.WriteLine("Path do datoteke: {0}.", item);
    }

    // Varijanta sa IEnumerable<string> files = Directory.EnumerateFiles
/*    Console.WriteLine();
    Console.WriteLine("----------------- Datoteke -----------------");
    Console.WriteLine();
    IEnumerable<string> files = Directory.EnumerateFiles(path);
        foreach (var file in files)
    {
        Console.WriteLine(file);
    }*/
}
else
{
    Console.WriteLine("Direktorij ne postoji");
}