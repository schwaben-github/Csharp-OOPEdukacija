// Napravi klasu Student (u odvojenoj datoteci) sa svojstvima: Ime, Prezime, GodinaRodjenja, MjestoStudiranja, OIB
// i metodama: Inicijali() – vraća inicijale studenta, Starost() – vraća starost studenta u godinama, ProvjeriOIB() – provjerava je li uneseni OIB ispravan (ima 11 znamenaka)
// 

namespace GDPR
{
    internal class Student
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int GodinaRodjenja { get; set; }
        public string MjestoStudiranja { get; set; }
        public string OIB { get; set; }

        public string Inicijali()
        {
            return Ime[0].ToString().ToUpper() + "." + Prezime[0].ToString().ToUpper() + ".";
        }

        public int Starost()
        {
            return DateTime.Now.Year - GodinaRodjenja;
        }

        public bool ProvjeriOIB()
        {
            long iOIB;
            if (OIB.Length != 11 || !long.TryParse(OIB, out iOIB))
                return false;

            int iOstatakDijeljenjaS11 = 10;
            for (int i = 0; i < 10; i++)
            {
                int iZnamenka = int.Parse(OIB[i].ToString());
                int iZbroj = iZnamenka + iOstatakDijeljenjaS11;

                int iCjelobrojnoPodijeli = iZbroj % 10;
                if (iCjelobrojnoPodijeli == 0)
                {
                    iCjelobrojnoPodijeli = 10;
                }
                int iUmnozak = iCjelobrojnoPodijeli * 2;
                iOstatakDijeljenjaS11 = iUmnozak % 11;
            }

            int iKontrolnaZnamenka = 11 - iOstatakDijeljenjaS11;
            if (iOstatakDijeljenjaS11 == 1)
            {
                iKontrolnaZnamenka = 0;
            }
            if (iKontrolnaZnamenka.ToString() != OIB[10].ToString())
            {
                return false;
            }
            return true;
        }

        /*int a = 10;
        for (int i = 0; i < 10; i++)
        {
            a = a + int.Parse(OIB.ToString()[i].ToString());
            a = a % 10;
            if (a == 0) a = 10;
            a *= 2;
            a = a % 11;
        }
        int kontrolnaZnamenka = 11 - a;
        if (kontrolnaZnamenka == 10) kontrolnaZnamenka = 0;

        return kontrolnaZnamenka == int.Parse(OIB.ToString()[10].ToString());*/
    }
}
