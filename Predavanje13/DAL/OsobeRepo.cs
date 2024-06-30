namespace DAL
{
    public class OsobeRepo
    {
        public static List<Osoba> lstOsosba = new()
        {
            new Osoba() {Ime ="Ivo", Prezime = "Čamagajevac"},
            new Osoba() {Ime ="Jozo", Prezime = "Parmačević"},
            new Osoba() {Ime ="Pero", Prezime = "Šaronić"},
            new Osoba() {Ime ="Ljubica", Prezime = "Cvenić"},
            new Osoba() {Ime ="Marko", Prezime = "Kraljević"},
        };

        public static List<Osoba> DohvatiOsobe()
        {
            List<Osoba> osobe = new List<Osoba>();
            foreach (Osoba item in lstOsosba)
            {
                Osoba osoba = new Osoba();
                osoba.Ime = item.Ime;
                osoba.Prezime = item.Prezime;
                osobe.Add(osoba);
            }
            return osobe;
        }

    }
}
