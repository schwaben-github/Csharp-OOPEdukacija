namespace Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Object - An instance of a class and is created from a class
            // Object can have fields and methods (characteristics & actions)
            // Object is created using the new keyword

            Human human1 = new Human();
            
            human1.name = "Rick";
            human1.age = 65;

            human1.Eat();
            human1.Sleep();


            Human human2 = new Human();

            human2.name = "Morty";
            human2.age = 16;

            human2.Eat();
            human2.Sleep();
        }
    }

    class Human
    {
        public string name;
        public int age;

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }
}
