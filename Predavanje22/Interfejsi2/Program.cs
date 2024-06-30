using Interfejsi2;
Point point = new Point();
point.X = 10;
point.Y = 20;
Console.WriteLine("Koordinate tocke su: ");
PrintPoint(point);

partial class Program
{
    static void PrintPoint(IPoint p)
    {
        Console.WriteLine("X={0}, Y={1}", p.X, p.Y);
    }
}