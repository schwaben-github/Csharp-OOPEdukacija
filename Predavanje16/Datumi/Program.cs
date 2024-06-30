// Kreiranje novog datuma
DateTime novaGodina = new DateTime(2025, 1, 1);

// Ispis datuma
Console.Write(novaGodina);

// Različiti formati ispisa datuma
Console.WriteLine(novaGodina.ToShortDateString());
Console.WriteLine(novaGodina.ToLongDateString());
Console.WriteLine(novaGodina.ToString("dd.MM.yy."));
Console.WriteLine(novaGodina.ToUniversalTime());

Console.WriteLine(novaGodina.ToString("ddd dd.MM.yy."));
Console.WriteLine(novaGodina.ToString("dddd, MMM dd.MMMM yy."));
Console.WriteLine(novaGodina.ToString("dddd, MMMM dd.MM.yyyy."));

Console.WriteLine("Trenutni datum je: {0}", DateTime.Today.ToString());
Console.WriteLine("Trenutno vrijeme je: {0}", DateTime.Now.ToString("d.M.yyyy.  HH.mm.ss.fff"));

Console.WriteLine("Nova godina pada na {0}.", novaGodina.DayOfWeek);
Console.WriteLine("Nova godina pada na {0}.", novaGodina.ToString("dddd"));
Console.WriteLine("Nova godina je {0}.", novaGodina.DayOfYear);


// Datumska aritmetika

Console.WriteLine("Novoj godini dodajem 35 dana: {0}", novaGodina.AddDays(45).ToShortDateString());
Console.WriteLine("Novoj godini oduzimam 35 dana: {0}", novaGodina.AddDays(-45).ToShortDateString());

// Razlika između datuma

Console.WriteLine("Do nove godine ima {0} dana.", (novaGodina - DateTime.Today).Days);
Console.WriteLine("Do nove godine ima {0} dana.", (novaGodina - DateTime.Today).TotalDays);
Console.WriteLine("Do nove godine ima {0} sati.", (novaGodina - DateTime.Now).Hours);
Console.WriteLine("Do nove godine ima {0} sati.", (novaGodina - DateTime.Now).TotalHours);
Console.WriteLine("Do nove godine ima {0} sati.", (novaGodina - DateTime.Now).TotalHours);


DateTime danas = DateTime.Today;
DateTime sutra = danas.AddDays(1);
DateTime prekosutra = danas.AddDays(2);
DateTime prijeDvaDana = danas.AddDays(-2);

Console.WriteLine("Danas je: {0}", danas);
Console.WriteLine("Sutra je: {0}", sutra);
Console.WriteLine("Prekosutra je: {0}", prekosutra);
Console.WriteLine("Prije dva dana je: {0}", prijeDvaDana);

// Razlika između datuma
TimeSpan razlika = prekosutra - sutra;

Console.WriteLine("Razlika između prekosutra i sutra je: {0}", razlika.Days);

// Provjera da li je godina prijestupna
int godina = 2024;
bool prijestupna = DateTime.IsLeapYear(godina);

Console.WriteLine("Godina {0} je prijestupna: {1}", godina, prijestupna);
