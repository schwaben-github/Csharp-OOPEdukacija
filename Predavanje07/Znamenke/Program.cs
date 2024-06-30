try
{
    Console.Write("Unesi prirodni broj: ");
    int broj = int.Parse(Console.ReadLine());

    if (broj < 0)
    {
        Console.WriteLine("Nisi unio prirodan broj...");
        return;
    }

    List<int> znamenke = RazdvojiZnamenke(broj);

    Console.WriteLine("Znamenke unatrag:");
    for (int i = znamenke.Count - 1; i >= 0; i--)
    {
        Console.Write(znamenke[i] + " ");
    }
}
catch (FormatException)
{
    Console.WriteLine("Nisi unio ispravan broj...");
}
catch (OverflowException)
{
    Console.WriteLine("Uneseni broj je izvan dozvoljenog raspona...");
}
catch (Exception ex)
{
    Console.WriteLine($"Došlo je do pogreške: {ex.Message}");
}
static List<int> RazdvojiZnamenke(int broj)
{
List<int> znamenke = new List<int>();

    while (broj > 0)
    {
        int znamenka = broj % 10;
        znamenke.Add(znamenka);
        broj /= 10;
    }

    return znamenke;
}