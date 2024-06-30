using System.Diagnostics;

try
{
	string datoteka = @"C:\Users\A47151139\OOP_Tecaj\1_parni.txt";
	FileStream fs = new FileStream(datoteka, FileMode.Create);
	StreamWriter sw = new StreamWriter(fs);

	for (int i = 1; i <= 100; i++)
	{
		if (i % 2 == 0)
		{
			sw.WriteLine(i);
		}
	}
	sw.Close();

	FileStream fs2 = new FileStream(datoteka, FileMode.Open);
    StreamReader sr2 = new StreamReader(fs2);
    string sadrzaj = sr2.ReadToEnd();
	sr2.Close();
    Console.WriteLine(sadrzaj);
}
catch (Exception e)
{
    Console.WriteLine("Greska: " + e.Message);
}

Console.WriteLine($"Parni brojevi su zapisani u datoteku: {datoteka}");