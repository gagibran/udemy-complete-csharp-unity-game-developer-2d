using System;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\gibra\Desktop\Projetos\learning-csharp-and-unity\" +
                       @"csharp-notes-and-exercises\WorkingWithFiles\file.txt";
            Console.WriteLine(Exercises.ExerciseOne(path));
            Console.WriteLine(Exercises.ExerciseTwo(path));
        }
    }
}
