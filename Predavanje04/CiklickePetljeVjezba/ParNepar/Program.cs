int broj;
int sumaNeparni = 0;
int sumaParni = 0;

do
{
    Console.Write("Unesite prirodni broj: ");
    broj = int.Parse(Console.ReadLine());

    if( broj % 2 == 0 )
    {
        sumaParni++;
    }
    else if( broj % 2 != 0 )
    {
        sumaNeparni++;
    }

} while (broj != 0);

Console.WriteLine("Unijeli ste {0} parnih i {1} neparnih brojeva!", sumaParni, sumaNeparni);