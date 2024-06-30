try
{
    Console.WriteLine("Unesi prirodni broj: ");
    int iUnos;
    string sUnos;

    sUnos = Console.ReadLine();
    iUnos = int.Parse(sUnos);
    if (iUnos <= 0)
    {
        throw new Exception("Broj nije prirodan.");
    }

    char[] znamenka = sUnos.ToCharArray();
    Array.Reverse(znamenka);
    foreach (char item in znamenka)
    {
        Console.Write(item);
    }
}
catch (Exception e)
{
    Console.WriteLine("Greška! Detalji: " + e.Message);
}