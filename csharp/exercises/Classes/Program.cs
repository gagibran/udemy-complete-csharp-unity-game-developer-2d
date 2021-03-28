using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // StackOverflow Post:
            var post = new StackOverflowPost("C# Constructors", "How do constructors in C# work?");
            post.DownVote();
            post.DownVote();
            post.DownVote();
            post.DownVote();
            post.DownVote();
            var commentOne = new StackOverflowPost("Is this a joke?", "Just read the documentation... Geez...");
            var commentTwo = new StackOverflowPost("Same as Java constructors");
            post.AddComment(commentOne);
            post.AddComment(commentTwo);
            commentOne.UpVote();
            commentOne.UpVote();
            commentOne.UpVote();
            commentOne.UpVote();
            commentOne.UpVote();
            commentOne.UpVote();
            commentTwo.UpVote();
            commentTwo.UpVote();
            commentTwo.UpVote();
            commentTwo.DownVote();
            Console.WriteLine($"The post \"{post.Title}\" has {post.Votes} votes.");
            post.GetComments();

            // Stopwatch:
            var stopWatch = new StopWatch();
            // stopWatch.CurrentSpan = new TimeSpan(0, 0, 0); // Invalid operation.
            // stopWatch.TimesStopped = 3; // Invalid operation.
            stopWatch.Start();
            for (int i = 0; i < 1000000000; i++)
            {

            }
            stopWatch.Stop();
            // stopWatch.Stop(); // Invalid operation.
            stopWatch.ResetTimer();
            stopWatch.Start();
            // stopWatch.Start(); // Invalid operation.
            for (int i = 0; i < 1000000000; i++)
            {

            }
            stopWatch.Stop();
            stopWatch.Start();
            for (int i = 0; i < 1000000000; i++)
            {

            }
            stopWatch.Stop();
        }
    }
}
