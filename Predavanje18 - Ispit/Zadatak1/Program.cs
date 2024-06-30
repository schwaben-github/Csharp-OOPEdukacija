using System;

string naopako = "";

try
{
    Console.Write("Unesi tekst: ");
    string tekst = Console.ReadLine();

    for (int i = tekst.Length - 1; i >= 0; i--)
    {
        naopako += tekst[i];
    }
}
catch (Exception e)
{
    Console.WriteLine("Doslo je do pogreske: " + e.Message);
}

Console.WriteLine("Tekst \"naopako\": " + naopako);