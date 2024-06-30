// Napravi klasu proizvod koja ima svojstva: Naziv(string), Cijena(double), Marža(double), Porez(double)
// i metodu: MPC() koja vraća cijenu proizvoda sa maržom i porezom.
//
// U glavnom programu kreiraj objekt klase Proizvod, traži od korisnika unos polja i zatim ispiši MPC.
// Program osiguraj od grešaka.

using ProizvodApp;

Proizvod proizvod = new Proizvod();

Console.Write("Unesite naziv proizvoda: ");
proizvod.Naziv = Console.ReadLine();

proizvod.Cijena = OsigurajOdGresaka("cijenu proizvoda");
proizvod.Marza = OsigurajOdGresaka("maržu proizvoda");
proizvod.Porez = OsigurajOdGresaka("porez proizvoda");

Console.WriteLine("---------------------------------------");
Console.WriteLine("MPC proizvoda {0} je {1}.", proizvod.Naziv, proizvod.MPC());

partial class  Program
{
    static double OsigurajOdGresaka(string stoUnosis)
    {
        bool repeat = true;
        double cijena = -1;
        do
        {
            try
            {
                Console.Write("Unesite {0}: ", stoUnosis);
                cijena = double.Parse(Console.ReadLine());
                if (cijena <= 0)
                {
                    throw new Exception();
                }
                repeat = false;

            }
            catch (Exception e)
            {
                Console.WriteLine("Nešto nije u redu: " + e.Message + " Pokušajte ponovno!");
            }
        } while (repeat);
        return cijena;
    }
}