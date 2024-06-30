// Interfejsi omogucavaju viseklasno nasledjivanje
// Klasa = kako, interfejs = sto
// Interfejsi su apstraktne klase koje sadrze samo deklaracije metoda, bez implementacije


partial class Program
{
    interface MojInterfejs
    {
        // Svojstva
        int MojBroj { get; set; }

        int VratiNesto();
        // {
        //     return 0;
        // }
    }

    public class Osoba : MojInterfejs
    {
        public int MojBroj { get; set; }

        public int VratiNesto()
        {
            return 5;
        }
    }

    public class Student : MojInterfejs
    {
        public int MojBroj { get; set; }

        public int VratiNesto()
        {
            return 10;
        }
    }
}