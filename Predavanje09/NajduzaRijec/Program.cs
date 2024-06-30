// Pronaci i ispisati najduzu rijec u stringu

Console.Write("Unesi rečenicu: ");
string recenica = Console.ReadLine();

Console.Write($"Najduža riječ: {NajduzaRijec(recenica)}");

partial class Program
{
    static string NajduzaRijec(string recenica)
    {
        List<string> rijeci = recenica.Split(" ").ToList();
        string najduzaRijec = "";
        foreach (string r in rijeci)
        {
            if (r.Length >= najduzaRijec.Length)
            {
                najduzaRijec = r;
            }
        }
        return najduzaRijec;
    }
}