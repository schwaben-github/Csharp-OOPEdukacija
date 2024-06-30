// BL = Business Layer

using DAL;

// Path: BL/Program.cs
// Desni klik na BL -> Add -> Project Reference -> check DAL -> OK

Student student = new Student(); // instanciranje objekta student klase Student

// instanciranje objekta može se napraviti i ovako:
// Student student = new Student() { Ime = "Tibor", Prezime = "Weigand", Matematika = 5, Kemija = 4, Fizika = 4 };
// ili ovako:
// Student student = new();

student.Ime = "Tibor";
student.Prezime = "Weigand";
student.Matematika = 5;
student.Kemija = 4;
student.Fizika = 4;

Console.WriteLine(student.ToString()); // DAL.Student
Console.WriteLine(student.Ime); // Tibor
Console.WriteLine(student.Prezime); // Weigand
Console.WriteLine(student.Matematika); 
Console.WriteLine(student.Kemija);
Console.WriteLine(student.Fizika);
Console.WriteLine(student.Prosjek()); // 4.33333333333333

List<Osoba> osobe = OsobeRepo.DohvatiOsobe();
