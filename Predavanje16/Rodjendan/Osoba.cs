using System.ComponentModel;
using System.Globalization;

namespace Rodjendan
{
    internal class Osoba
    {
        public delegate void RodjendanDelegat(object sender, EventArgs e);
        public event RodjendanDelegat Rodjendan;

        public string Ime { get; set; }
        public string Prezime { get; set; }
        private DateTime datumRodjenja;
        public DateTime DatumRodjenja
        {
            get
            {
                return datumRodjenja;
            }
            set
            {
                datumRodjenja = value;
                if (Rodjendan != null)
                {
                    Rodjendan(this, new EventArgs());
                }
            }
        }
        public int Starost
        {
            get
            {
                DateTime sada = DateTime.Now;
                TimeSpan razlika = sada.Subtract(DatumRodjenja);
                return razlika.Days / 365;
            }
        }
        public Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }
        public Osoba() { }

        public Spol Spol { get; set; }

        // Metoda koja vraća dan rođenja osobe na hrvatskom jeziku

        public string DayOfBirthday()
        {
            CultureInfo hr = new CultureInfo("hr-HR");
            return DatumRodjenja.ToString("dddd", hr);
        }

    }
    public enum Spol
    {
        [Description("Muški")]
        Muski,
        [Description("Ženski")]
        Zenski
    }
}
