Console.Write("Unesi godinu: ");
int godina = int.Parse(Console.ReadLine());

if ((godina % 4 == 0 && godina % 100 != 0) || (godina % 400 == 0))
{
    Console.WriteLine("Godina je (bila) prijestupna.");
}
else
{
    Console.WriteLine("Godina nije (bila )prijestupna.");
}