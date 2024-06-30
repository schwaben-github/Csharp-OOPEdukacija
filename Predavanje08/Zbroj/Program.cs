Console.Write("Unesi prvi broj: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Unesi drugi broj: ");
int b = int.Parse(Console.ReadLine());

ZbrojDvaBroja(a, b);

partial class Program
{
    static void ZbrojDvaBroja(int x, int y)
    {
        int c = x + y;
        Console.Write("Zbroj ova dva unesena broja je " + c);
    }
}