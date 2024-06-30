// Napravi klasu Zaposlenik koja ima svojstva: Ime(string), Prezime(string), OIB(int), BrojBodova(int), VrijednostBoda(double),
// Porez(double, Read Only svojstvo, 5 % ako je NetoPlaca <= 3000, 10 % ako je 3000 < NetoPlaca <= 6000, 20 % ako je NetoPlaca > 6000)
// metode: NetoPlaca() koja vraća neto plaću zaposlenika (BrojBodova * VrijednostBoda) i BrutoPlaca() koja vraća ukupnu plaću zaposlenika (NetoPlaca + Porez).
// konstruktore: defaultni, konnstruktor s parametrima ime i prezime te konstruktor s parametrima ime, prezime i OIB.

namespace ZaposlenikApp
{
    internal class Zaposlenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string OIB { get; set; }
        public int BrojBodova { get; set; }
        public double VrijednostBoda { get; set; }
        public double Porez
        {
            get
            {
                double netoPlaca = BrojBodova * VrijednostBoda;
                if (NetoPlaca() <= 3000)
                {
                    return NetoPlaca() * 0.05;
                }
                else if (NetoPlaca() < 6000)
                {
                    return NetoPlaca() * 0.1;
                }
                else
                {
                    return NetoPlaca() * 0.2;
                }
            }
        }

        public double NetoPlaca()
        {
            return BrojBodova * VrijednostBoda;
        }

        public double BrutoPlaca()
        {
            return NetoPlaca() + Porez;
        }

        public Zaposlenik()
        {
        }

        public Zaposlenik(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }

        public Zaposlenik(string ime, string prezime, int oib)
        {
            Ime = ime;
            Prezime = prezime;
            OIB = oib;
        }
    }
}

