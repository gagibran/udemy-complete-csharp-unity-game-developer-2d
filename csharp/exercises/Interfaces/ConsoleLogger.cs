using System;

namespace Interfaces
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red; // Changing the property color of the console log to red.
            Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow; // Changing the property color of the console log to blue.
            Console.WriteLine(message);
        }
    }
}
