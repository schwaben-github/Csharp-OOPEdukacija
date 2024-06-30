using System;

class Program
{
    static void Main(string[] args)
    {
        string logLine = LogLine.LogLevel("[ERROR]: Disk full");
        Console.WriteLine($"Log line: {logLine}");

        // Ispisivanje poruke
        string message = LogLine.Message(logLine);
        Console.WriteLine($"Message: {message}");

        // Ispisivanje razine logiranja
        string logLevel = LogLine.LogLevel(logLine);
        Console.WriteLine($"Log level: {logLevel}");

        // Reformatiranje log linije
        string reformattedLine = LogLine.Reformat(logLine);
        Console.WriteLine($"Reformatted line: {reformattedLine}");
    }
}