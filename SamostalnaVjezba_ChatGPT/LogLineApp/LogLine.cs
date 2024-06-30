using System;
using System.Text.RegularExpressions;

public static class LogLine
{
    public static string Message(string logLine)
    {
        // Extract the message from the log line
        var messageMatch = Regex.Match(logLine, @"\]:\s*(.*)");
        // Remove any leading or trailing white space
        return messageMatch.Groups[1].Value.Trim();
    }

    public static string LogLevel(string logLine)
    {
        // Extract the log level from the log line
        var levelMatch = Regex.Match(logLine, @"\[(.*?)\]");
        // Return the log level in lowercase
        return levelMatch.Groups[1].Value.ToLower();
    }

    public static string Reformat(string logLine)
    {
        // Extract the message and the log level
        string message = Message(logLine);
        string logLevel = LogLevel(logLine);
        // Return the reformatted log line
        return $"{message} ({logLevel})";
    }
}