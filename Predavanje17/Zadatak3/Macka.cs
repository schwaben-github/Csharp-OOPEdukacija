namespace Zadatak3
{
    internal class Macka : Zivotinja
    {
        public string Boja { get; set; }
        public new string GlasajSe()
        {
            return "Mijau";
        }
        public override string ToString()
        {
            return "mačka";
        }
    }
}

// Originalno rješenje:

/*namespace Zadatak3
{
    internal class Macka : Zivotinja
    {
        public string Boja { get; set; }

        private string GlasajSe()
        {
            return "Mijau";
        }

        // Override metode ToString()
        public override string ToString()
        {
            return $"Mačka, {Starost()} g., {Spol}, {GlasajSe()}";
        }
    }
}
*/