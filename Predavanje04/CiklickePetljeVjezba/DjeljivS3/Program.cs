// Napiši program koji ispisuje sve prirodne brojeve iz segmenta [1, 500] djeljive sa 3.

int counter = 0;

for (int i = 1; i <= 500; i++)
{
	if (i % 3 == 0)
	{
        Console.WriteLine(i);
        counter++;
	}
}
