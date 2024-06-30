using System;

int unos = 1;
string s2i3 = "";
string s2aline3 = "";
string s3aline2 = "";
string ni2ni3 = "";

while (unos != 0)
{
    try
    {
        Console.Write("Unesi broj (\"0\" za kraj unosa): ");
        unos = int.Parse(Console.ReadLine());

        if (unos % 2 == 0 && unos % 3 == 0)
        {
            s2i3 += unos + " ";
        }
        else if (unos % 2 == 0 && unos % 3 != 0)
        {
            s2aline3 += unos + " ";
        }
        else if (unos % 2 != 0 && unos % 3 == 0)
        {
            s3aline2 += unos + " ";
        }
        else
        {
            ni2ni3 += unos + " ";
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Doslo je do pogreske: " + e.Message);
    }
}

Console.WriteLine("Brojevi djeljivi s 2 i 3 su:  " + s2i3);
Console.WriteLine("Brojevi djeljivi s 2 ali ne sa 3 su:  " + s2aline3);
Console.WriteLine("Brojevi djeljivi s 3 ali ne sa 2 su:  " + s3aline2);
Console.WriteLine("Brojevi koji nisu djeljivi ni s 2 ni s 3:  " + ni2ni3);