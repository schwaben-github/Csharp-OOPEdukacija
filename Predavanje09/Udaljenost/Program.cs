Console.WriteLine("Unos koordinata točke P");
List<double> tockaP = UnesiKoordinate();

Console.WriteLine("Unos koordinata točke R");
List<double> tockaR = UnesiKoordinate();

Console.Write("Udaljenost točaka je :" + RacunajUdaljenost(tockaP, tockaR));

Console.WriteLine();

partial class Program
{
    static List<double> UnesiKoordinate()
    {
        List<double> tocka = new List<double>();
        Console.Write("Unesi x koordinatu točke: ");
        tocka.Add(double.Parse(Console.ReadLine()));
        Console.Write("Unesi x koordinatu točke: ");
        tocka.Add(double.Parse(Console.ReadLine()));
        return tocka;
    }

    static double RacunajUdaljenost(List<double> P, List<double> R)
    {
        return Math.Sqrt(Math.Pow(P[0] - R[0], 2) + Math.Pow(R[1] - P[1], 2));
    }
}