// Napiši program koji će ispisati koliko ima brojeva djeljivih sa 5, a nedjeljivih sa 2 u segmentu [1, 100]

int counter = 0;
for (int i = 0; i <= 100; i++)
{
	if (i % 5 == 0 && i % 2 != 0)
	{
		counter++;
	}
}
Console.WriteLine("U segmentu [1, 100] ima ukupno {0} brojeva djeljivih sa 5, a nedjeljivih sa 2", counter);