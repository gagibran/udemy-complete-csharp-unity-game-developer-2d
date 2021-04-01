using System;

namespace Interfaces
{
    public class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending e-mail...\n");
            Console.WriteLine("\"Hi,\n\nYour video has been uploaded to the cloud.\n\nBest regards,\n\nSome Tech Company.\"\n");
            Console.WriteLine("E-mail sent.");
        }
    }
}
