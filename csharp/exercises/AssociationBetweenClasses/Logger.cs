using System;

namespace AssociationBetweenClasses
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Message \"{message}\" attached to the log file.");
        }
    }
}
