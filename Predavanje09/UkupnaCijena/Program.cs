
double cijena;

while (true)
{

    try
    {
        Console.Write("Unesi ulaznu cijenu: ");
        cijena = double.Parse(Console.ReadLine());
        if (cijena <= 0)
        {
            throw new Exception("Cijena mora biti veća od nule...");
        }
        break;
    }
    catch (Exception e)
    {
        Console.WriteLine("Greška: " + e.Message);
    } 
}

Console.WriteLine("Ukupna cijena: " + UkupnaCijena(cijena));

partial class Program
{
    static double UkupnaCijena(double ulaznaCijena)
    {
        double ukupnaCijena = 0;
        if (ulaznaCijena > 1000)
        {
            ukupnaCijena = ulaznaCijena + 50 + ulaznaCijena * 0.1;
        }
        else if (ulaznaCijena > 500)
        {
            ukupnaCijena = ulaznaCijena + 25 + ulaznaCijena * 0.05;
        }
        else if (ulaznaCijena > 250)
        {
            ukupnaCijena = ulaznaCijena + 15 + ulaznaCijena * 0.04;
        }
        else if (ulaznaCijena > 100)
        {
            ukupnaCijena = ulaznaCijena + 9.5 + ulaznaCijena * 0.03;
        }
        else if (ulaznaCijena > 0)
        {
            ukupnaCijena = ulaznaCijena + 5.5 + ulaznaCijena * 0.02;
        }
        return ukupnaCijena;
    }
}