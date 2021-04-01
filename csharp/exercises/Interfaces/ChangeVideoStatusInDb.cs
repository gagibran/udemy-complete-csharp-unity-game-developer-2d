using System;

namespace Interfaces
{
    public class ChangeVideoStatusInDb : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Changing the status from \"Idle\" to processing in the database...");
            Console.WriteLine("The status was successfully changed.");
        }
    }
}
