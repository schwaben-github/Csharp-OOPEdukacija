// Napravi klasu sa static metodama: Zbroj(double broj1, double broj2), kub(double broj), UdaljenostTocaka(double x1, double x2, double y1, double y2),  CelzijFahrenheit(int stupnjevi)
// Napomena: Klasa se ne smije moći instancirati!

namespace KalkulatorApp
{
    static class Kalkulator
    {
        public static decimal Zbroj(decimal broj1, decimal broj2)
        {
            return broj1 + broj2;
        }

        public static double Kub(double broj)
        {
            return Math.Pow(broj, 3);
        }

        public static double UdaljenostTocaka(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public static double CelzijFahrenheit(double stupnjevi)
        {
            return stupnjevi * 9 / 5 + 32;
        }
    }
}
