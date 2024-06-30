namespace DataAccessLayer
{
    public class Polaznik : Osoba
    {
        public string ProgramObrazovanja { get; set; }
        public new string PunoIme()
        {
            return Prezime + ", " + Ime;
        }
        public override string ToString()
        {
            return PunoIme() + " - " + ProgramObrazovanja;
        }
    }
}
