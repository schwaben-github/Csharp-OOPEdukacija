// Napiši program koji ispisuje sve prijestupne godine od 1900. do 2007.
// Godina je prijestupna ako je djeljiva sa 4 i nije djeljiva sa 100 ili je djeljiva sa 400.

int counter  = 0;

for (int i = 1900; i <= 2024; i++)
{
	if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0)
	{
        Console.WriteLine(i);
        counter++;
    }
}