try
{
	// Path izvrsavanja aplikacije
	Console.WriteLine(Environment.CurrentDirectory);

	string datoteka = Path.Combine(Environment.CurrentDirectory, "proba.txt");
	    Console.WriteLine(datoteka);

    Console.WriteLine("Ime datoteke: {0}", Path.GetFileName(datoteka));
    Console.WriteLine("Naziv foldera unutar kojeg se smjestena datoteka: {0}", Path.GetDirectoryName(datoteka));

    Console.WriteLine(Path.GetDirectoryName(Environment.CurrentDirectory));

    // Provjera postojanja datoteke
    StreamWriter sw = File.CreateText(datoteka);
    sw.WriteLine("Ovo je tekst upisan uz pomos koda...");

    if (File.Exists(datoteka))
    {
        Console.WriteLine("Datoteka postoji");
    }
    else
    {
        Console.WriteLine("Datoteka ne postoji");
    }

    // Provjera postojanja foldera
    Directory.CreateDirectory("d1");

    if (Directory.Exists("d1"))
    {
        Console.WriteLine("Direktorij postoji");
    }
    else
    {
        Console.WriteLine("Direktorij ne postoji");
    }

    // Lista poddirektorija u tekucem direktoriju
    Console.WriteLine("Poddirektoriji: ");
    string[] poddirektoriji = Directory.GetDirectories(Environment.CurrentDirectory);
    foreach (string item in poddirektoriji)
    {
        Console.WriteLine("Puna putanja do direktorija: {0}.", item);
    }

    // Lista datoteka u tekucem direktoriju
    Console.WriteLine("Datoteke: ");
    string[] datoteke = Directory.GetFiles(Environment.CurrentDirectory);
    foreach (var item in datoteke)
    {
        Console.WriteLine("Puna putanja do datoteke: {0}.", item);
    }

    Console.WriteLine("--------------------------------");
    foreach (string item in datoteke)
    {
        FileInfo fi = new FileInfo(item);
        Console.WriteLine("Ime datoteke: {0}", fi.Name);
        Console.WriteLine("Path: " + Path.GetFileName(item));
    }

    /*// Brisanje datoteke
    File.Delete(datoteka);
    if (File.Exists(datoteka))
    {
        Console.WriteLine("Datoteka postoji");
    }
    else
    {
        Console.WriteLine("Datoteka ne postoji");
    }

    // Brisanje direktorija
    Directory.Delete("dl");
    if (Directory.Exists("dl"))
    {
        Console.WriteLine("Direktorij postoji");
    }
    else
    {
        Console.WriteLine("Direktorij ne postoji");
    }*/
}
catch (Exception e)
{
    Console.WriteLine("Greska: " + e.Message);
}