Console.Write("Unesi jedan (pozitivan ili negativan) cijeli broj: ");
int broj = int.Parse(Console.ReadLine());

int duljina = broj.ToString().Length;

if (duljina == 1)
{
    Console.WriteLine("Uneseni broj je jednoznamenkast.");
}
else if (duljina == 2)
{
    Console.WriteLine("Uneseni broj je dvoznamenkast.");
}
else if (duljina == 3)
{
    Console.WriteLine("Uneseni broj je troznamenkast.");
}
else
{
    Console.WriteLine("Uneseni broj je višeznamenkast.");
}