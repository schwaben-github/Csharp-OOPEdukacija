using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvaTri
{
    internal class OtvoriDatoteku
    {
        static void OtvoriDatotekuUDefaultnomProgramu(string putanja)
        {
            try
            {
                Process.Start(putanja);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Došlo je do greške prilikom otvaranja datoteke: " + ex.Message);
            }
        }
    }
}
