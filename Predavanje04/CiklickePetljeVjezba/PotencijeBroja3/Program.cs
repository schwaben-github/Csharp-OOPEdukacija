// Napiši program u kojem se ispisuju sve potencije broja 3 manje od 1000.

int i = 1;
while (Math.Pow(3, i) < 1000)
{
    Console.WriteLine("Potencija broja 3 manja od 1000: " + Math.Pow(3, i));
    i++;
}