// Napiši program koji traži unos putanje i ispisuje naziv prvog pronađenog direktorija na putanji
// po abecednom redu, silazno. Program ne smije prijaviti grešku ako nije pronađen niti jedan direktorij.

using System;
using System.IO;
using System.Linq;

Console.Write("Unesite putanju: ");
string putanja = Console.ReadLine();
if (Directory.Exists(putanja))
{
    string[] direktoriji = Directory.GetDirectories(putanja);
    string prviDirektorij = direktoriji.OrderBy(d => d).FirstOrDefault();
    if (prviDirektorij != null)
    {
        Console.WriteLine(prviDirektorij);
    }
}
