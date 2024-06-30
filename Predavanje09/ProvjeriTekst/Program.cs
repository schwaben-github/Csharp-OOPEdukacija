// Provjeri koliko ima izjavnih upitnih i usklicnih recenica u tekstu

Console.Write("Unesi rečenicu: ");
string recenica = Console.ReadLine();

Console.Write($"Broj izjavnih rečenica: {PrebrojiZnakove(recenica, '.')} ");
Console.Write($"Broj upitnih rečenica: {PrebrojiZnakove(recenica, '?')} ");
Console.Write($"Broj uskličnih rečenica: {PrebrojiZnakove(recenica, '!')} ");

partial class Program
{
    static int PrebrojiZnakove(string recenica, char znak)
    {
        int brojac = 0;
        foreach (char c in recenica)
        {
            if (c == znak)
            {
                brojac++;
            }
        }
        return brojac;
    }
}