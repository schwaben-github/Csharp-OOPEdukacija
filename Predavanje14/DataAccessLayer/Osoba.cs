namespace DataAccessLayer
{
    public class Osoba
    {
        #region Svojstva
        private string ime;
        private string prezime;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        #endregion

        #region Metode
        public string PunoIme()
        {
            return Ime + " " + Prezime;
        }
        public override string ToString()
        {
            return PunoIme();
        }
        #endregion
    }
}
