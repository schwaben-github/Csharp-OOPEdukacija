// Class - A bundle of related code
// Blueprint for creating objects

using Classes;

class Program
{
    static void Main(string[] args)
    {
        Math.Sqrt(4);
        Math.Round(4.5);
        Math.Abs(-4);
        Math.Pow(2, 3);

        Messages.Hello();
        Messages.Waiting();
        Messages.Bye();
    }    
}

// This class has been moved to the Messages.cs file!
/*public static class Messages
{
    public static void Hello()
    {
        Console.WriteLine("Hello");
    }
    public static void Waiting()
    {
        Console.WriteLine("I'm waiting");
    }
    public static void Bye()
    {
        Console.WriteLine("Bye! Thanks for stopping by!");
    }
}*/

// New class name is always PascalCase
// New class can be created by right clicking on the namespace and selecting Add -> Class
// Or inside the same file as the main class
