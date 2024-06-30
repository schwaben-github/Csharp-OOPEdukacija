double kvadratBroja = Kvadrat(5);
Console.WriteLine(kvadratBroja);
//moram iskoristiti vraćenu vrijednost ili ju spremiti u varijablu a ne samo ju pozvati: Kvadrat(10);
int uneseniBroj = UcitajCijeliBroj();
bool uspjesno = UcitajCijeliBroj2();
Console.WriteLine();
partial class Program
{
    static double Kvadrat(double broj)
    {
        return broj * broj;
    }
    static int UcitajCijeliBroj()
    {
        Console.Write("Unesi broj: ");
        int broj = int.Parse(Console.ReadLine());
        return broj;
    }
    static bool UcitajCijeliBroj2()
    {
        Console.Write("Unesi broj: ");
        try
        {
            int broj = int.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
            return false;

        }
        return true;
    }
}