
Console.WriteLine("Pritisnite bilo koju tipku za početak mjerenja vremena.");
Console.ReadKey();
DateTime pocetak = DateTime.Now;

Console.WriteLine("Pritisnite bilo koju tipku za završetak mjerenja vremena.");
Console.ReadKey();
DateTime kraj = DateTime.Now;

TimeSpan protekloVrijeme = kraj - pocetak;
Console.WriteLine("Proteklo vrijeme: {0} sati, {1} minuta, {2} sekundi, {3} milisekundi.",
                   protekloVrijeme.Hours, protekloVrijeme.Minutes, protekloVrijeme.Seconds, protekloVrijeme.Milliseconds);