namespace Zadatak3
{
    internal class Pas : Zivotinja
    {
        public string Ime { get; set; }
        public string Pasmina { get; set; }
        public new string GlasajSe()
        {
            return "Vau";
        }
        public override string ToString()
        {
            return "pas";
        }
    }
}

// Originalno rješenje:

/*namespace Zadatak3
{
    internal class Pas : Zivotinja
    {
        public string Ime { get; set; }
        public string Pasmina { get; set; }


        private string GlasajSe()
        {
            return "Vau";
        }


        public override string ToString()
        {
            return $"Pas, {Starost()} g., {Spol}, {GlasajSe()}";
        }
    }
}
*/