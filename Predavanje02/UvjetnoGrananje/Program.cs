// grananje - if elseif else

// testiramo logički izraz
/*using System.Collections.Concurrent;

if (9 > 5)
{
    Console.WriteLine("9 je veće od 5.");
}
else
{
    Console.WriteLine("Nije točno!");
}
*/


/*
// ako je uvjet false - preskače se code block
if (9 < 5)
{
    Console.WriteLine("9 je veće od 5.");
}
*/



// Primjer 1
/*Console.WriteLine("Unesi korisničko ime: ");
string username = Console.ReadLine();
if (username.ToLower() == "polaznik")
{
    Console.WriteLine("Dobro došao, polazniče!");
}
else
{
    Console.WriteLine("Krivo korisničko ime!");
}*/


// Primjer 2
/*Console.WriteLine("Unesi jedan cijeli broj: ");
int broj = int.Parse(Console.ReadLine());
if (broj > 10)
{
    Console.WriteLine("Broj je veći od 10!");
}
else if (broj == 10)
{
    Console.WriteLine("Broj je jednak 10!");
}
else
{
    Console.WriteLine("Broj je manji od 10!");
}*/


// Primjer 3
/*Console.WriteLine("Unesi jedan cijeli broj: ");
int broj = int.Parse(Console.ReadLine());
if (broj > 300)
{
    Console.WriteLine("Broj je veći od 100!");
}
else if (broj > 200)
{
    Console.WriteLine("Broj je veći od 200!");
}
else if (broj > 100)
{
    Console.WriteLine("Broj je veći od 300!");
}
*/


// Ugnježdeni if
Console.WriteLine("Unesi jedan cijeli broj: ");
int broj = int.Parse(Console.ReadLine());
if (broj > 0)
{
    Console.WriteLine("Broj je pozitivan!");
}
else
{
    if (broj < 0)
    {
        Console.WriteLine("Broj je negativan!");
    }
    else
    {
        Console.WriteLine("Broj je nula!");
    }
}
Console.WriteLine();