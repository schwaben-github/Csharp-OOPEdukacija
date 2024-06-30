Console.Write("Unesi duljinu katete a: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Unesi duljinu katete b: ");
double b = double.Parse(Console.ReadLine());

IspisiDuljinuHipotenuze(b, a);

partial class Program
{
    static void IspisiDuljinuHipotenuze(double x, double y)
    {
        double c = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        Console.WriteLine("c = " + Math.Round(c, 2));
    }
}