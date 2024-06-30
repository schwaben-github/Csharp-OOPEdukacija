// 

using Studenti;

class Program
{
    static void Main()
    {
        List<Student> studenti = UnesiStudente();
        IspisiProsjeke(studenti);

        static List<Student> UnesiStudente()
        {
            List<Student> studenti = new List<Student>();
            while (true)
            {
                Console.Write("Unesite ime studenta (ili prazan string za kraj): ");
                string ime = Console.ReadLine();
                if (ime == "")
                    break;
                Student student = new Student(ime);
                Console.Write("Unesite prezime studenta: ");
                student.Prezime = Console.ReadLine();
                while (true)
                {
                    Console.Write("Unesite ocjenu studenta (ili 0 za kraj): ");
                    int ocjena = int.Parse(Console.ReadLine());
                    if (ocjena == 0)
                        break;
                    student.Ocjene.Add(ocjena);
                }
                studenti.Add(student);
            }
            return studenti;
        }

        static void IspisiProsjeke(List<Student> studenti)
        {
            foreach (Student student in studenti)
            {
                Console.WriteLine($"Prosjek ocjena studenta {student.Ime} {student.Prezime} je {student.Prosjek()}");
            }
        }
    }
}

