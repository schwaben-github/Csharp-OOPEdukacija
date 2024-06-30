// Traži se unos 10 prirodnih brojeva, zatim se ispisuje najmanji i najveći od njih.

try
{
    int min = int.MaxValue;
    int max = int.MinValue;

    for (int i = 0; i < 10; i++)
    {
        Console.Write("Unesi prirodni broj: ");
        int broj = int.Parse(Console.ReadLine());
        if (broj < min)
        {
            min = broj;
        }
        else if (broj > max)
        {
            max = broj;
        }
    }
    Console.WriteLine("Najmanji: " + min);
    Console.WriteLine("Najveći: " + max);
}
catch (Exception)
{
    Console.WriteLine("Dogodila se greška!");
}