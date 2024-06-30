#region Unos
List<int> s2i3 = new List<int>();
List<int> s2aliNes3 = new List<int>();
List<int> s3aliNes2 = new List<int>();
List<int> ostali = new List<int>();

int unosBroja = -1;
do
{
    try
    {
        Console.Write("Unesite broj: (unesite 0 za kraj):");
        unosBroja = int.Parse(Console.ReadLine());

        // Provjeri broj i klasificiraj ga
        if (unosBroja > 0)
        {
            if (unosBroja % 2 == 0 && unosBroja % 3 == 0)
            {
                s2i3.Add(unosBroja);
            }
            else if (unosBroja % 2 == 0)
            {
                s2aliNes3.Add(unosBroja);
            }
            else if (unosBroja % 3 == 0)
            {
                s3aliNes2.Add(unosBroja);
            }
            else
            {
                ostali.Add(unosBroja);
            }
        }
        else if (unosBroja < 0)
        {
            throw new Exception("Broj mora biti veći od 0.");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Dogodila se greška: " + e.Message);
    }

} while (unosBroja != 0);
#endregion

#region Ispis
Console.WriteLine("----------------------------------------");
Console.WriteLine("Brojevi djeljivi s 2 i 3:");
foreach (int broj in s2i3)
{
    Console.WriteLine(broj);
}

Console.WriteLine("----------------------------------------");
Console.WriteLine("Brojevi djeljivi s 2 ali ne s 3:");
foreach (int broj in s2aliNes3)
{
    Console.WriteLine(broj);
}

Console.WriteLine("----------------------------------------");
Console.WriteLine("Brojevi djeljivi s 3 ali ne s 2:");
foreach (int broj in s3aliNes2)
{
    Console.WriteLine(broj);
}

Console.WriteLine("----------------------------------------");
Console.WriteLine("Ostali brojevi:");
foreach (int broj in ostali)
{
    Console.WriteLine(broj);
}
#endregion