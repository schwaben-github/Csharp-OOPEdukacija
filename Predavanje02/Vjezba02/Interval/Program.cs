Console.Write("Unesi jedan cijeli broj: ");
int broj = int.Parse(Console.ReadLine());

if (broj >= 0 && broj <= 12)
{
    Console.WriteLine("Uneseni broj je u intervalu [0, 12].");
}
else
{
    Console.WriteLine("Uneseni broj nije u intervalu [0, 12].");
}