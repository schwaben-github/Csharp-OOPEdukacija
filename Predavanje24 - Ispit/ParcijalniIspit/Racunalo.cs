using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcijalniIspit
{
    public class Racunalo
    {
        public string Naziv { get; set; }
        public double Cijena { get; set; }
        public int JamstvoMjeseci { get; set; }

        private DateTime datumKupnje;

        public DateTime DatumKupnje
        {
            get { return datumKupnje; }
            set
            {
                if (datumKupnje != value)
                {
                    datumKupnje = value;
                    OnPromjenaDatumaKupnje(EventArgs.Empty);
                }
            }
        }

        public event EventHandler NaPromjenuDatumaKupnje;

        public Racunalo(string naziv, double cijena, int jamstvoMjeseci, DateTime datumKupnje)
        {
            Naziv = naziv;
            Cijena = cijena;
            JamstvoMjeseci = jamstvoMjeseci;
            DatumKupnje = datumKupnje;
        }

        public double Starost()
        {
            return (DateTime.Now - DatumKupnje).TotalDays / 365.25;
        }

        public virtual double Vrijednost()
        {
            double starostUGodinama = Starost();
            double postotakSmanjenja = 1 - (Math.Floor(starostUGodinama) * 0.1);

            if (postotakSmanjenja < 0)
                postotakSmanjenja = 0;

            return Cijena * postotakSmanjenja;
        }

        public override string ToString()
        {
            string jeLiUJamstvu = (DateTime.Now <= DatumKupnje.AddMonths(JamstvoMjeseci)) ? "Da" : "Ne";
            return $"Naziv: {Naziv}\nCijena: {Cijena:C}\nJamstvo: {JamstvoMjeseci} mjeseci\nDatum Kupnje: {DatumKupnje.ToShortDateString()}\nStarost: {Starost():F2} godina\nTrenutna Vrijednost: {Vrijednost():C}\nU Jamstvu: {jeLiUJamstvu}";
        }

        protected virtual void OnPromjenaDatumaKupnje(EventArgs e)
        {
            EventHandler handler = NaPromjenuDatumaKupnje;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
