// upis broja predmeta
Console.Write("Unesite broj predmeta: ");
int brojPredmeta = int.Parse(Console.ReadLine());

double[] ocjene = new double[brojPredmeta];

// za svaki predmet upisuje se ocjena
// ukoliko unesena ocjena nije iz intervala [1, 5] ponavlja se unos
for (int i = 0; i < brojPredmeta; i++)
{
    double ocjena;
    do
    {
        Console.Write($"Unesite ocjenu za {i + 1}. predmet: ");
        ocjena = double.Parse(Console.ReadLine());
    } while (ocjena < 1 || ocjena > 5);
    ocjene[i] = ocjena;
}

bool neuspjeh = false;
double sumaOcjena = 0;

// provjerava se ima li "negativnih" ocjena
// ako ima, izlazi se iz petlje
foreach (double ocjena in ocjene)
{
    if (ocjena == 1)
    {
        neuspjeh = true;
        break;
    }
    sumaOcjena += ocjena;
}

// ispis rezultata ovisno ako je bool neuspjeh = true
if (neuspjeh)
{
    Console.WriteLine("Uspjeh je nedovoljan!");
}
else
{
    double prosjek = sumaOcjena / brojPredmeta;
    Console.WriteLine($"Završni uspjeh je: {prosjek:F2}");
}