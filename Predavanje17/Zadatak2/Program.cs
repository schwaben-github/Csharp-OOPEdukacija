using System;
using System.Collections.Generic;

Dictionary<char, List<string>> rijeci = new Dictionary<char, List<string>>();
string rijec;

do
{
    try
    {
        Console.Write("Unesi riječ (\"kraj\" za kraj): ");
        rijec = Console.ReadLine();
        if (rijec.ToLower() == "kraj")
        {
            break;
        }
        if (rijec.Length == 0)
        {
            throw new Exception("Unos ne smije biti prazan!");
        }
        if (!char.IsLetter(rijec[0]))
        {
            throw new Exception("Pretpostavljam da riječi uglavnom počinju slovom...");
        }
        if (!rijeci.ContainsKey(char.ToUpper(rijec[0])))
        {
            rijeci[char.ToUpper(rijec[0])] = new List<string>();
        }
        rijeci[char.ToUpper(rijec[0])].Add(rijec);
    }
    catch (Exception e)
    {
        Console.WriteLine("Greška: " + e.Message);
        continue;
    }
} while (true);


foreach (var keyValuePair in rijeci)
{
    Console.WriteLine($"Riječi koje počinju slovom {keyValuePair.Key}:");
    foreach (var r in keyValuePair.Value)
    {
        Console.WriteLine(r);
    }
    Console.WriteLine();
}