Console.Write("Unesi jedan broj: ");
int broj = int.Parse(Console.ReadLine());

if (broj % 2 == 0 && broj % 3 == 0)
{
    Console.WriteLine("Broj je djeljiv sa 6!");
}
else
{
    Console.WriteLine("Broj nije djeljiv sa 6.");
}