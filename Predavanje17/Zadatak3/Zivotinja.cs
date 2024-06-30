using System;

namespace Zadatak3
{
    internal class Zivotinja
    {
        public delegate void BudjenjeDelegat(object sender, EventArgs e);
        public event BudjenjeDelegat Budjenje;

        private string vlasnik;
        private DateTime godinaRodjenja;
        private double masa;
        private Spol spol;
        private int vrijemeBudjenja;
        private int vrijemeSpavanja;

        public string Vlasnik { get => vlasnik; set => vlasnik = value; }
        public DateTime GodinaRodjenja { get => godinaRodjenja; set => godinaRodjenja = value; }
        public double Masa { get => masa; set => masa = value; }
        public Spol Spol { get => spol; set => spol = value; }
        public int VrijemeBudjenja
        {
            get
            {
                return vrijemeBudjenja;
            }
            set
            {
                vrijemeBudjenja = value;

                //je li događaj implementiran
                if (Budjenje != null)
                {
                    Budjenje(this, new EventArgs());
                }
            }
        }
        public event EventHandler NaSpavanje;
        public int VrijemeSpavanja
        {
            get
            {
                return vrijemeSpavanja;
            }
            set
            {
                vrijemeSpavanja = value;
                NaSpavanje?.Invoke(this, EventArgs.Empty);
            }
        }
        public string Spavaj()
        {
            return "Zzzzz...";
        }
        public string GlasajSe()
        {
            return "Grrr.....";
        }
        public int Starost()
        {
            return DateTime.Now.Subtract(GodinaRodjenja).Days / 365;
        }
    }
    public enum Spol
    {
        Muski,
        Zenski
    }
}

// Originalno rješenje:

/*namespace Zadatak3
{
    internal class Zivotinja
    {
        public string Vlasnik { get; set; }
        public DateTime GodinaRodjenja { get; set; }
        public double Masa { get; set; }
        public Spol Spol { get; set; }
        public int VrijemeBudjenja { get; set; }
        public int VrijemeSpavanja { get; set; }

        public event EventHandler NaSpavanje;
        public event EventHandler Budjenje;

        public string Spavaj()
        {
            if (DateTime.Now.Hour >= VrijemeSpavanja)
            {
                return "Zzzz...";
            }
            else
            {
                return GlasajSe();
            }
        }

        public string GlasajSe()
        {
            return "Grrr...";
        }

        public int Starost()
        {
            return DateTime.Now.Year - GodinaRodjenja.Year;
        }


        private void PostaviVrijemeSpavanja(int vrijemeSpavanja)
        {
            VrijemeSpavanja = vrijemeSpavanja;

            if (DateTime.Now.Hour >= VrijemeSpavanja)
            {
                OnNaSpavanje(EventArgs.Empty);
            }
        }


        private void PostaviVrijemeBudjenja(int vrijemeBudjenja)
        {
            VrijemeBudjenja = vrijemeBudjenja;

            OnBudjenje(EventArgs.Empty);
        }


        protected virtual void OnNaSpavanje(EventArgs e)
        {
            NaSpavanje?.Invoke(this, e);
        }


        protected virtual void OnBudjenje(EventArgs e)
        {
            Budjenje?.Invoke(this, e);
        }
    }


    public enum Spol
    {
        Muski,
        Zenski
    }
}*/