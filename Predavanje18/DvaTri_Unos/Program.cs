using System.Diagnostics;

try
{
    string datotekaParni = "parni.txt";
    string datotekaNeparni = "neparni.txt";
    FileStream fsParni = new FileStream(datotekaParni, FileMode.Create);
    StreamWriter swParni = new StreamWriter(fsParni);

    FileStream fsNeparni = new FileStream(datotekaNeparni, FileMode.Create);
    StreamWriter swNeparni = new StreamWriter(fsNeparni);

    int broj;
    do
    {
        Console.Write("Unesite prirodan broj (0 za kraj): ");
        broj = int.Parse(Console.ReadLine());

        if (broj % 2 == 0)
        {
            swParni.WriteLine(broj);
        }
        else
        {
            swNeparni.WriteLine(broj);
        }
    } while (broj != 0);

    swParni.Close();
    swNeparni.Close();

    Console.WriteLine("Brojevi su uspješno zapisani u datoteke.");

    if (Environment.OSVersion.Platform == PlatformID.Win32NT)
    {
        // Mali dodatak: Otvaranje datoteka u Notepadu...
        // Otvori datoteku parni.txt u Notepadu
        Process.Start("notepad.exe", datotekaParni);
        // Otvori datoteku neparni.txt u Notepadu
        Process.Start("notepad.exe", datotekaNeparni);
    }
    else if (Environment.OSVersion.Platform == PlatformID.Unix)
    {
        Process.Start("osascript", $"-e TextEdit {datotekaParni}");
        Process.Start("osascript", $"-e TextEdit {datotekaNeparni}");
    }
    else
    {
        throw Exception("Nepodržani operacijski sustav!");
    }

}
catch (Exception e)
{
    Console.WriteLine("Greska: " + e.Message);
}