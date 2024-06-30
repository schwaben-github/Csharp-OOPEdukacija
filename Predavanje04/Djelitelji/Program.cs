// 1. unos broja
// 2. a) pronaći i ispisati djelitelje
// 2. b) zbrojiti djelitelje
// 3. "Broj je / nije prost"

int broj = -1;
bool unosNijeDobar = true;

do
{
    Console.Write("Unesi prirodan broj: ");
	try
	{
		broj = int.Parse(Console.ReadLine());
		if (broj > 1)
		{
            unosNijeDobar = false;
        }
		else
		{
			throw new Exception();
		}

	}
	catch (Exception)
	{
        Console.WriteLine("Krivi unos!");
	}
} while (unosNijeDobar);  // jednako kao unosNijeDobar == true


int counter = 0;
for (int i = 1; i <= broj; i++)
{
	if (broj % i == 0)
	{
        Console.WriteLine(i);
        counter++;
    }
}
if (counter == 2)
{
    Console.WriteLine("Broj je prost!");
}
else
{
    Console.WriteLine("Broj nije prost!");
}