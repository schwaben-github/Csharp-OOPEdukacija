namespace Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constructor - A special method that is called when an object is created
            // Constructor has the same name as the class
            // Constructor can be used to set initial values for fields and to assign arguments to fields when creating an object

            /*Human human1 = new Human("Rick", 65);

            human1.Eat();
            human1.Sleep();

            Human human2 = new Human("Morty", 16);

            human2.Eat();
            human2.Sleep();

            Human human3 = new Human("Jerry", 40);

            human3.Eat();
            human3.Sleep();*/


            Car car1 = new Car("Ford", "Mustang", 2019, "Red");
            car1.Drive();

            Car car2 = new Car("Chevy", "Corvette", 2021, "Blue");
            car2.Drive();
        }
    }

    /*class Human
    {
        public string name;
        public int age;

        // Constructor
        public Human(string name, int age)
        {
            Console.WriteLine();
            Console.WriteLine("Constructor has been called!");
            this.name = name;
            this.age = age;
        }

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }*/

    class Car
    {
        public string make;
        public string model;
        public int year;
        public string color;

        public Car(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

       
        public void Drive()
        {
            Console.WriteLine("You are driving the " + year + " " + make + " " + model + " " + color);
        }
    }   
}
