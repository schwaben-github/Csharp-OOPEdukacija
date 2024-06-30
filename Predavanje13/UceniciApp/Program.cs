using UceniciDAL;

// Path: UceniciApp/Program.cs
// Desni klik na UceniciApp -> Add -> Project Reference -> check UceniciDAL -> OK

Ucenik ucenik = new Ucenik("Jozo", "Barić");
ucenik.Matematika = 2;
ucenik.Fizika = 3;
ucenik.Kemija = 2;

Console.WriteLine(ucenik.ToString()); // Jozo Barić, prosjek: 2,3333333333333335