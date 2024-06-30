namespace Zadatak3
{
    internal class Ucenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        private DateTime _datumRodjenja;
        public DateTime DatumRodjenja
        {
            get { return _datumRodjenja; }
            set
            {
                _datumRodjenja = value;
                NaPromjenuDatumaRodjenja?.Invoke(this, EventArgs.Empty); // 2. Poziv događaja
            }
        }

        public double Prosjek { get; set; }

        public int Starost()
        {
            return DateTime.Now.Subtract(DatumRodjenja).Days / 365;
        }

        //podrazumijeva se da je prosjek unesen u rasponu od 1 do 5
        public string ProsjekRijecima()
        {
            if (Prosjek < 1.5)
            {
                return "nedovoljan";
            }
            else if (Prosjek < 2.5)
            {
                return "dovoljan";
            }
            else if (Prosjek < 3.5)
            {
                return "dobar";
            }
            else if (Prosjek < 4.5)
            {
                return "vrlo dobar";
            }
            else
            {
                return "odličan";
            }
        }

        // 1. Definicija događaja
        public event EventHandler NaPromjenuDatumaRodjenja;
    }
}
