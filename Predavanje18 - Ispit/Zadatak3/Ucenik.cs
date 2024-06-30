namespace Zadatak3
{
    public class Ucenik
    {
        public void PromijeniDatumRodjenja(DateTime noviDatum)
        {
            DatumRodjenja = noviDatum;
            NaPromjenuDatumaRodjenja?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler NaPromjenuDatumaRodjenja;

        public string Ime { get; set; }
        public string Prezime { get; set; }

        private DateTime _datumRodjenja;
        public DateTime DatumRodjenja
        {
            get { return _datumRodjenja; }
            set
            {
                if (_datumRodjenja != value)
                {
                    _datumRodjenja = value;
                    NaPromjenuDatumaRodjenja?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public double Prosjek { get; set; }

        public int Starost()
        {
            return DateTime.Now.Year - DatumRodjenja.Year;
        }

        public string ProsjekRijecima()
        {
            if (Prosjek < 1.5)
            {
                return "nedovoljan";
            }
            else if (Prosjek >= 1.5 && Prosjek < 2.5)
            {
                return "dovoljan";
            }
            else if (Prosjek >= 2.5 && Prosjek < 3.5)
            {
                return "dobar";
            }
            else if (Prosjek >= 3.5 && Prosjek < 4.5)
            {
                return "vrlo dobar";
            }
            else if (Prosjek >= 4.5 && Prosjek <= 5.0)
            {
                return "odličan";
            }
            else
            {
                return "Nije moguće ocijeniti";
            }
        }

        public Ucenik(string ime, string prezime, DateTime datumRodjenja, double prosjek)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            Prosjek = prosjek;
        }
    }
}
