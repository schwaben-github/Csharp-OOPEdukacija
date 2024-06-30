string recenica = "Danas radimo sa stringovima!";

Console.WriteLine(recenica);

// ToLower()
Console.WriteLine(recenica.ToLower());

// ToUpper()
Console.WriteLine(recenica.ToUpper());

// Substring() - wraća dio teksta, prima dva parametra, početni indeks i broj znakova
Console.WriteLine(recenica.Substring(0, 5));
Console.WriteLine(recenica.Substring(6));  // Ako se ne navede drugi parametar, vraća sve znakove od početnog indeksa do kraja!

// Length() - vraća broj znakova u stringu
Console.WriteLine(recenica.Length);

// Ispis pojedinih znakova
Console.WriteLine(recenica[13]);

// IndexOf() - vraća indeks prvog pojavljivanja traženog znaka
Console.WriteLine(recenica.IndexOf('!'));
Console.WriteLine(recenica.IndexOf(""));

// LastIndexOf() - vraća indeks zadnjeg pojavljivanja traženog znaka
Console.WriteLine(recenica.LastIndexOf(" "));

// za nepostojeći znak vraća -1
Console.WriteLine(recenica.IndexOf("x"));

// Replace() - zamjenjuje jedan znak drugim
Console.WriteLine(recenica.Replace("radimo", "ne radimo"));

// Split() - razdvaja string na dijelove
string[] rijeci = recenica.Split(' ');
for (int i = 0; i < rijeci.Length; i++)
{
    Console.WriteLine(rijeci[i]);
}

// StartsWith() - provjerava počinje li string traženim znakovima
Console.WriteLine(recenica.StartsWith("Danas"));

// EndsWith() - provjerava završava li string traženim znakovima
Console.WriteLine(recenica.EndsWith("!"));

// Contains() - provjerava sadrži li string tražene znakove
Console.WriteLine(recenica.Contains("sa"));

// Trim() - uklanja praznine s početka i kraja stringa
string recenica2 = "    Ovo je recenica sa prazninama na početku i kraju.    ";
Console.WriteLine(recenica2);
Console.WriteLine(recenica2.Trim());

// PadLeft() - dodaje znakove s lijeve strane stringa
Console.WriteLine(recenica.PadLeft(50, '*'));

// PadRight() - dodaje znakove s desne strane stringa
Console.WriteLine(recenica.PadRight(50, '*'));

// Format() - formatira string
string formatirano = string.Format("Naziv: {0}, Cijena: {1}", "Kruh", 4.5);
Console.WriteLine(formatirano);
Console.WriteLine(recenica2.Trim());

// Compare() - uspoređuje dva stringa
Console.WriteLine(string.Compare("abc", "abc"));

// CompareTo() - uspoređuje dva stringa
Console.WriteLine("abc".CompareTo("abc"));

// Equals() - uspoređuje dva stringa
Console.WriteLine("abc".Equals("abc"));

// Concat() - spaja dva stringa
Console.WriteLine(string.Concat("abc", "def"));
Console.WriteLine(string.Concat("abc", "def", "ghi"));

// IsNullOrEmpty() - provjerava je li string prazan ili null
Console.WriteLine(string.IsNullOrEmpty(""));

// IsNullOrWhiteSpace() - provjerava je li string prazan ili null
Console.WriteLine(string.IsNullOrWhiteSpace(""));
Console.WriteLine(string.IsNullOrWhiteSpace(" "));
Console.WriteLine(string.IsNullOrWhiteSpace(null));

// Join() - spaja elemente niza u string
string[] niz = { "abc", "def", "ghi" };
Console.WriteLine(string.Join(" ", niz));
Console.WriteLine(string.Join(" ", niz).ToUpper());
Console.WriteLine(string.Join(" ", niz).ToLower());
Console.WriteLine(string.Join(" ", niz).Substring(4, 3));
Console.WriteLine(string.Join(" ", niz).Length);
Console.WriteLine(string.Join(" ", niz).IndexOf("d"));
Console.WriteLine(string.Join(" ", niz).LastIndexOf("d"));

// ToCharArray() - pretvara string u niz znakova
char[] znakovi = recenica.ToCharArray();
for (int i = 0; i < znakovi.Length; i++)
{
    Console.WriteLine(znakovi[i]);
}

// Contains() - provjerava sadrži li string tražene znakove
Console.WriteLine(recenica.Contains("sa"));

// IndexOfAny() - vraća indeks prvog pojavljivanja traženog znaka
char[] znakovi2 = { 'a', 'b', 'c' };
Console.WriteLine(recenica.IndexOfAny(znakovi2));

// LastIndexOfAny() - vraća indeks zadnjeg pojavljivanja traženog znaka
Console.WriteLine(recenica.LastIndexOfAny(znakovi2));

// Remove() - uklanja znakove iz stringa
Console.WriteLine(recenica.Remove(5));
Console.WriteLine(recenica.Remove(5, 10));

