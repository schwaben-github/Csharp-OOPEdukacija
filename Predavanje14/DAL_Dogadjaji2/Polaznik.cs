using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Dogadjaji2
{
    public class Polaznik : Osoba
    {
        //deklaracija događaja
        public delegate void NaPromjenuPODelegat(object sender, EventArgs e);
        public event NaPromjenuPODelegat NaPromjenuPO;

        private string programObrazovanja;

        public string ProgramObrazovanja
        {
            get
            {
                return programObrazovanja;
            }
            set
            {
                programObrazovanja = value;
                if (NaPromjenuPO != null)
                {
                    NaPromjenuPO(this, new EventArgs());
                }
            }
        }
    }
}
