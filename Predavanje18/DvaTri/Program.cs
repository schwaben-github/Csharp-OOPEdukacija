using System.Diagnostics;

try
{
    string datoteka1 = "2ili3NoviRed.txt";
    FileStream fStream = new FileStream(datoteka1, FileMode.Create);
    StreamWriter sWriter = new StreamWriter(fStream);

    for (int i = 1; i <= 100; i++)
    {
        if (i % 2 == 0 || i % 3 == 0)
        {
            sWriter.WriteLine(i);
        }
    }

    sWriter.Close();

    bool prviBroj = true;
    string datoteka2 = "2ili3SaZarezima.txt";
    FileStream fStream2 = new FileStream(datoteka2, FileMode.Create);
    StreamWriter sWriter2 = new StreamWriter(fStream2);

    for (int i = 1; i <= 100; i++)
    {
        if (i % 2 == 0 || i % 3 == 0)
        {
            if (!prviBroj)
            {
                sWriter2.Write(", ");
            }
            sWriter2.Write(i);
            prviBroj = false;
        }
    }

    sWriter2.Close();

    Console.WriteLine("Brojevi su uspješno zapisani u datoteke. ");

    // Mali dodatak: Otvaranje datoteka u Notepadu ;)
    // Otvori datoteku 2ili3NoviRed.txt u Notepadu
    Process.Start("notepad.exe", datoteka1);
    // Otvori datoteku 2ili3SaZarezima.txt u Notepadu
    Process.Start("notepad.exe", datoteka2);

}
catch (Exception e)
{
    Console.WriteLine("Greska: " + e.Message);
}