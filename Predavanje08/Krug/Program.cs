Console.Write("Unesi polumjer: ");
double r = double.Parse(Console.ReadLine());

// 1. način
double o = Opseg(r);
Console.WriteLine("Opseg je: " + Math.Round(o, 2));

// 2. način
Console.WriteLine("Površina je: " + Math.Round(Povrsina(r)));

partial class Program
{
    static double Opseg(double r)
    {
        return 2 * r * Math.PI;
    }

    static double Povrsina(double r)
    {
        return Math.Pow(r, 2) * Math.PI;
    }
}