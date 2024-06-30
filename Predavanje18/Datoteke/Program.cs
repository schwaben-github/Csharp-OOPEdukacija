
try
{
	// 1. definiramo path do datoteke
	string datoteka = @"C:\Users\A47151139\OOP_Tecaj\proba.txt";

    // 2. kreiramo novu tekstualnu datoteku
    FileStream fs1 = new FileStream(datoteka, FileMode.Create);

    // 3. kreiramo novi kanal prema navedenoj datoteci u sustavu
    StreamWriter sw1 = new StreamWriter(fs1);

    // 4. upisujemo novi sadrzaj u datoteku
    sw1.WriteLine("Prva linija teksta!");
    sw1.WriteLine("Druga linija teksta!");
    sw1.WriteLine("Treca linija teksta!");
    sw1.WriteLine("Cetvrta linija teksta!");
    sw1.Close();

    // 5. Dodavanje teksta u datoteku
    FileStream fs2 = new FileStream(datoteka, FileMode.Append);
    StreamWriter sw2 = new StreamWriter(fs2);
    sw2.WriteLine("Dodana linija teksta!");
    sw2.Close();

    // 6. Citanje cijelog sadrzaja iz datoteke
    FileStream fs3 = new FileStream(datoteka, FileMode.Open);
    StreamReader sr3 = new StreamReader(fs3);
    string sadrzaj = sr3.ReadToEnd();
    sr3.Close();
    Console.WriteLine(sadrzaj);

    // 7. Citanje red po red iz datoteke
    FileStream fs4 = new FileStream(datoteka, FileMode.Open);
    StreamReader sr4 = new StreamReader(fs4);

    while (!sr4.EndOfStream)
    {
        string red = sr4.ReadLine();
        Console.WriteLine(red + ", ");
    }
    sr4.Close();

    // 8. Ispis informacija o datoteci
    Console.WriteLine("-----------------------------");
    FileInfo fi = new FileInfo(datoteka);
    Console.WriteLine(fi.FullName);
    Console.WriteLine(fi.Name);
    Console.WriteLine(fi.Length);
    Console.WriteLine(fi.DirectoryName);
    Console.WriteLine(fi.Extension);
    Console.WriteLine(fi.CreationTime);
    Console.WriteLine(fi.LastWriteTime);
}
catch (Exception e)
{
    Console.WriteLine("Greska: " + e.Message);
}