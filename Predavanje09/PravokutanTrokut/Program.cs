// Pravokutan trokut!

try
{
    Console.Write("Unesi duljinu jedne katete a: ");
    double a = double.Parse(Console.ReadLine());

    Console.Write("Unesi duljinu druge katete b: ");
    double b = double.Parse(Console.ReadLine());

    double p = Trokut(a, b);
    Console.WriteLine("Površina pravokutnog trokuta je: " + Math.Round(p, 2));
}
catch (Exception e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Došlo je do pogreške: " + e.Message);
    Console.ForegroundColor = ConsoleColor.Gray;
}

partial class Program
{
    static double Trokut(double a, double b)
    {
        if (a <= 0 || b <= 0)
        {
            throw new ArgumentException("Duljine kateta moraju biti pozitivni brojevi.");
        }

        double povrsina = (a * b) / 2;
        return povrsina;
    }
}