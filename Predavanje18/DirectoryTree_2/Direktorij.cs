using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryTree_2
{
    public static class Direktorij
    {
        static int DohvatiDubinu(string putanja)
        {
            int razina = 0;
            foreach (char item in poddirektoriji)
            {
                if (item == '\\')
                {
                    razina++;
                }
            }
            return razina;
        }

        // Rekurzivna metoda za ispisivanje direktorija
        public static void DohvatiDirektorije(string putanja, int razina)
        {
            try
            {
                Console.WriteLine("{0} {1}", new string('-', DohvatiDubinu(putanja) * 3), Path.GetFileName(putanja));

                string[] poddirektoriji = Directory.GetDirectories(putanja);
                foreach (string item in poddirektoriji)
                {
                    DohvatiDirektorije(item, razina + 2);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
