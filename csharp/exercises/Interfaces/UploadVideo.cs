using System;

namespace Interfaces
{
    public class UploadVideo : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading video to the cloud...");
        }
    }
}
