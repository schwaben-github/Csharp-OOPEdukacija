namespace AktivnostiApp
{
    internal class Osoba
    {
        public string Ime { get; set; }
        public byte Dob { get; set; }
        public float Visina { get; set; }
        public byte Masa { get; set; }

        public event EventHandler Hodanje;
        public event EventHandler Pricanje;
        public event EventHandler Hranjenje;
        public event EventHandler Spavanje;

        public void Hodaj()
        {
            if (Hodanje != null)
            {
                Hodanje(this, new EventArgs());
            }
        }

        public void Govori()
        {
            if (Pricanje != null)
            {
                Pricanje(this, new EventArgs());
            }
        }

        public void Jedi()
        {
            if (Hranjenje != null)
            {
                Hranjenje(this, new EventArgs());
            }
        }

        public void Spavaj()
        {
            if (Spavanje != null)
            {
                Spavanje(this, new EventArgs());
            }
        }
    }
}
