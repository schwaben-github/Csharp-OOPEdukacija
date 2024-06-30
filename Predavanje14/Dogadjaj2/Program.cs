using DAL_Dogadjaji2;

Osoba o = new Osoba();
//implementacija događaja
o.NaPromjenuImena += new Osoba.NaPromjenuImenaDelegat(o_NaPromjenuImena);
o.NaPozivPI += new Osoba.NaPozivPIDelegat(p_NaPozivPI);
o.Ime = "Pero";
o.Prezime = "Perković";
Console.WriteLine(o.PunoIme());

Polaznik p = new Polaznik();
p.NaPromjenuPO += new Polaznik.NaPromjenuPODelegat(p_NaPromjenuPO);
p.NaPozivPI += new Osoba.NaPozivPIDelegat(p_NaPozivPI);
p.Ime = "Sandra";
p.Prezime = "Sandrić";
p.ProgramObrazovanja = "ECDL osnove";
p.PunoIme();
Console.WriteLine(p.PunoIme());


partial class Program
{
    //metode koje se izvršavaju na podizanju događaja
    static void p_NaPozivPI(object sender, EventArgs e)
    {
        Console.WriteLine($"Pozvana je metoda PunoIme() objekta {((Osoba)sender).Ime}");
    }
    static void p_NaPromjenuPO(object sender, EventArgs e)
    {
        Polaznik p = (Polaznik)sender;
        Console.WriteLine($"Čestitamo {p.Ime} {p.Prezime}, upisali ste: {p.ProgramObrazovanja}");
    }
    static void o_NaPromjenuImena(object sender, EventArgs e)
    {
        Console.WriteLine($"Promijenilo se ime! Novo ime je {((Osoba)sender).PunoIme()}");
    }
}

