// Napravi program koji za upisani tekstualni naziv mjeseca ispisuje njegov redni broj.
// Za krivo upisani naziv mjeseca, ispisuje se da taj mjesec ne postoji.

Console.Write("Upiši naziv mjeseca: ");
string nazivMjeseca = Console.ReadLine().ToLower();

int redniBroj;
switch (nazivMjeseca)
{
    case "siječanj":
        redniBroj = 1;
        break;
    case "veljača":
        redniBroj = 2;
        break;
    case "ožujak":
        redniBroj = 3;
        break;
    case "travanj":
        redniBroj = 4;
        break;
    case "svibanj":
        redniBroj = 5;
        break;
    case "lipanj":
        redniBroj = 6;
        break;
    case "srpanj":
        redniBroj = 7;
        break;
    case "kolovoz":
        redniBroj = 8;
        break;
    case "rujan":
        redniBroj = 9;
        break;
    case "listopad":
        redniBroj = 10;
        break;
    case "studeni":
        redniBroj = 11;
        break;
    case "prosinac":
        redniBroj = 12;
        break;
    default:
        redniBroj = -1;
        break;
}

if (redniBroj != -1)
{
    Console.WriteLine($"Redni broj mjeseca '{nazivMjeseca}' je: {redniBroj}...");
}
else
{
    Console.WriteLine("Mjesec '{0}' ne postoji.", nazivMjeseca);
}