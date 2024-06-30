using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosudbaApp
{
    internal static class Izbornici
    {
        public static void Glavni()
        {
            bool ponovi = false;
            do
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("╔═ MOJE POSUDBE ═╗");
                Console.WriteLine("║ 1. Prijatelji  ║");
                Console.WriteLine("║ 2. Mediji      ║");
                Console.WriteLine("║ 3. Posudbe     ║");
                Console.WriteLine("║ 4. Kraj        ║");
                Console.WriteLine("╚════════════════╝");
                Console.WriteLine();
                Console.Write("Odaberi jednu od opcija: ");
                string odabir = Console.ReadLine();
                switch (odabir)
                {
                    case "1":
                        Prijatelji();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        return;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nepoznata opcija!");
                        ponovi = true;
                        Thread.Sleep(1000);
                        break;
                }
            } while (ponovi);
        }

        public static void Prijatelji()
        {
            bool ponovi = false;
            do
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("╔══ PRIJATELJI ══╗");
                Console.WriteLine("║  1. Dodaj      ║");
                Console.WriteLine("║  2. Ispiši     ║");
                Console.WriteLine("║  3. Izmijeni   ║");
                Console.WriteLine("║  4. Obriši     ║");
                Console.WriteLine("║  5. Izlaz      ║");
                Console.WriteLine("╚════════════════╝");
                Console.WriteLine();
                Console.Write("Odaberi jednu od opcija: ");
                string odabir = Console.ReadLine();
                switch (odabir)
                {
                    case "1":
                        PosudbaApp.ModulPrijatelji.Create();
                        break;
                    case "2":
                        PosudbaApp.ModulPrijatelji.Read();
                        break;
                    case "3":
                        PosudbaApp.ModulPrijatelji.Update();
                        break;
                    case "4":
                        PosudbaApp.ModulPrijatelji.Delete();
                        break;
                    case "5":
                        Glavni();
                        return;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nepoznata opcija!");
                        ponovi = true;
                        Thread.Sleep(1000);
                        break;
                }
            } while (ponovi);
        }
    }
}