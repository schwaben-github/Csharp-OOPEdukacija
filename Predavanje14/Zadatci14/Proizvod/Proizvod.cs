namespace Proizvodi
{
    internal class Proizvod
    {
        public string Naziv { get; set; }
        public double OsnovnaCijena { get; set; }
        private double marza;
        public double Marza
        {
            get
            {
                return marza;
            }
            set
            {
                if (value >= 0 && value <= 1)
                {
                    marza = value;
                }
                else
                {
                    throw new Exception("Marza mora biti iz intervala [0,1]");
                }
            }
        }

        public event EventHandler NaIzracunCijene;
        public void IzracunajCijenu()
        {
            double cijena = OsnovnaCijena + OsnovnaCijena * Marza;
            Console.WriteLine($"Cijena proizvoda {Naziv} je {cijena}");
            NaIzracunCijene?.Invoke(this, EventArgs.Empty);
        }
    }
}
