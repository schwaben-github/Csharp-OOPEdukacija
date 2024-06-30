using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcijalniIspit
{
    public class Laptop : Racunalo
    {
        public double TrajanjeBaterije { get; set; }

        public Laptop(string naziv, double cijena, int jamstvoMjeseci, DateTime datumKupnje, double trajanjeBaterije)
            : base(naziv, cijena, jamstvoMjeseci, datumKupnje)
        {
            TrajanjeBaterije = trajanjeBaterije;
        }

        public override string ToString()
        {
            string jeLiUJamstvu = (DateTime.Now <= DatumKupnje.AddMonths(JamstvoMjeseci)) ? "Da" : "Ne";
            return $"Naziv: {Naziv}\nCijena: {Cijena:C}\nJamstvo: {JamstvoMjeseci} mjeseci\nDatum Kupnje: {DatumKupnje.ToShortDateString()}\nStarost: {Starost():F2} godina\nTrenutna Vrijednost: {Vrijednost():C}\nU Jamstvu: {jeLiUJamstvu}\nTrajanje Baterije: {TrajanjeBaterije} sati";
        }

        public new double Vrijednost()
        {
            double starostUGodinama = Starost();
            double postotakSmanjenja = 1 - (Math.Floor(starostUGodinama) * 0.15);

            if (postotakSmanjenja < 0)
                postotakSmanjenja = 0;

            return Cijena * postotakSmanjenja;
        }
    }
}
