// 

using KalkulatorApp;

/*Kalkulator kalkulator = new Kalkulator();
kalkulator.BrojA = 2;
kalkulator.BrojB = 3;*/

decimal rezultat = Kalkulator.Zbroj(2, 3);
Console.WriteLine(rezultat);

Console.WriteLine(Kalkulator.Kub(2));

Console.WriteLine(Kalkulator.UdaljenostTocaka(2, 3, 4, 5));

Console.WriteLine(Kalkulator.CelzijFahrenheit(100d));