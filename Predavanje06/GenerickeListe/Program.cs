using System.Collections;

/*// Array Liste
ArrayList lstLista = new ArrayList();
lstLista.Add(1);
lstLista.Add("2");*/


//Generičke Liste
List<string> lstStringova  = new List<string>();

lstStringova.Add("Riječ 1");
lstStringova.Add("Riječ 2");
lstStringova.Add("Riječ 3");

foreach (string s in lstStringova)
{
    Console.WriteLine(s);
}
Console.WriteLine("Gotovo!");