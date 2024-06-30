Console.Write("Unesi riječ: ");
string rijec = Console.ReadLine().ToLower().Replace(" ", "").Replace(",", "").Replace("!", "").Replace("?", "");

if (Palindrom(rijec))
{
    Console.WriteLine("Riječ je palindrom!");
}
else
{
    Console.WriteLine("Riječ nije palindrom!");
}

partial class Program()
{
    static bool Palindrom(string rijec)
    {
        char[] slova = rijec.ToCharArray();

        Array.Reverse(slova);
        string naopako = new string(slova);
        if (rijec == naopako)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}