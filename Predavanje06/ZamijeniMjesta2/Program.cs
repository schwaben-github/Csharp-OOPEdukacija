//Napiši program u kojem se traži unos 10 brojeva koji se zatim ispisuju, ali najvećem i 
//najmanjem treba zamijeniti mjesta.

List<double> lstBrojeva = new List<double>();
for (int i = 0; i < 10; i++)
{
    bool bOk = false;
    while (!bOk)
    {
        Console.Write($"Unesi {i + 1}. broj: ");
        try
        {
            double iBroj = double.Parse(Console.ReadLine());
            lstBrojeva.Add(iBroj);
            bOk = true;
        }
        catch (Exception)
        {
            Console.WriteLine("Dogodila se greška. Ponovi unos.");
        }
    }
}
double dMin = lstBrojeva.Min();
double dMax = lstBrojeva.Max();
// -10, 1, 22, 123, -10  //zapamti 
// 123, 1, 22, 123, 123
// -10, 1, 22, -10, -10
foreach (double dBroj in lstBrojeva)
{
    if (dBroj == dMin)
    {
        Console.Write(dMax + " ");
    }
    else if (dBroj == dMax)
    {
        Console.Write(dMin + " ");
    }
    else
    {
        Console.Write(dBroj + " ");
    }
}
