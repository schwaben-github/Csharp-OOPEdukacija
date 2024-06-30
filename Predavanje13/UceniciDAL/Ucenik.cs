namespace UceniciDAL
{
    public class Ucenik : Osoba
    {
        public int Matematika { get; set; }
        public int Fizika { get; set; }
        public int Kemija { get; set; }

        public Ucenik(string ime, string prezime) : base(ime, prezime)
        {
        }

        public double VratiProsjek()
        {
            return (Matematika + Fizika + Kemija) / 3.0;
        }

        public override string ToString()
        {
            return PunoIme() + ", prosjek: " + VratiProsjek();
        }
    }
}
