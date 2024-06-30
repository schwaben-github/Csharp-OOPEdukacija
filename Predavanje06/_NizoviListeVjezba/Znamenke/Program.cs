Console.Write("Unesi prirodan broj: ");
int broj;

if (!int.TryParse(Console.ReadLine(), out broj) || broj <= 0)
{
    Console.WriteLine("Niste unijeli ispravan prirodan broj.");
    return;
}

List<int> znamenke = RazdvojiZnamenke(broj);

Console.WriteLine("Znamenke upisanog broja unatrag su:");
for (int i = znamenke.Count - 1; i >= 0; i--)
{
    Console.Write(znamenke[i] + " ");
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