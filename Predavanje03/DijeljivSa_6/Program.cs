Console.Write("Unesi broj: ");
int broj = int.Parse(Console.ReadLine());

if (broj % 2 == 0 && broj % 3 == 0)
{
    Console.WriteLine("Broj je dijeljiv sa 6");
}
else
{
    Console.WriteLine("Broj nije dijeljiv sa 6");
}