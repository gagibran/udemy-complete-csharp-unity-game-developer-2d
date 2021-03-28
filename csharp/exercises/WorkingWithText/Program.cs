using System;
using System.Text;

namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            //var fullName = "Gabriel Gibran ";
            //Console.WriteLine("Trim '{0}'", fullName.Trim()); // Removes whitespace on the beginning and at the end.
            //Console.WriteLine("ToUpper '{0}'", fullName.ToUpper());
            //Console.WriteLine("ToLower '{0}'", fullName.ToLower());
            //Console.WriteLine("IndexOf '{0}'", fullName.ToLower());

            //// Creating a substring:
            //var index = fullName.IndexOf(' '); // Returns the first instance of a whitespace.
            //var firstName = fullName.Substring(0, index); // Creates a substring from the 0th position until the first whitespace. In other words: the first name.
            //var lastName = fullName.Substring(index + 1).Trim(); // Creates a substring from after the whitespace until the end. In other words: the last name.

            //// Creating a substring from Split():
            //Console.WriteLine(fullName.Split(' ')[1]); // Split() returns an array.

            //// Replace:
            //Console.WriteLine(fullName.Replace("Gabriel", "Gab"));

            //// Null strings:
            //if (String.IsNullOrEmpty(" ")) // Works for null or "".
            //{
            //    Console.WriteLine("The string is empty or null.");
            //}

            //// To detect an empty string with whitespace we can either do a trim, or use the better and newer method:
            //if (String.IsNullOrWhiteSpace(" "))
            //{
            //    Console.WriteLine("The string is empty, null, or filled with whitespace.");
            //}

            //// Using format strings:
            //double price = 12.45;
            //Console.WriteLine(price.ToString("C"));
            //Console.WriteLine(price.ToString("C0")); // Gets rid of the decimal points.

            //// Using the summarizer:
            //Console.WriteLine();
            //Console.WriteLine(StringUtility.Summarize("Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet." , 25));
            //Console.WriteLine();

            //// String builder:
            //var stringBuilder = new StringBuilder("Hello, world."); // Builds a StringBuilder with "Testing".
            //stringBuilder.AppendLine(); // Appends a \n to the end of the StringBuilder.
            //stringBuilder.Append('-', 10); // Appends the char '-' to the end of the StringBuilder 10 times.
            //stringBuilder.AppendLine();
            //stringBuilder.Append("Header"); // Appends the string "Header" to the end of the StringBuilder.
            //stringBuilder.AppendLine();
            //stringBuilder.Append('-', 10);
            //Console.WriteLine(stringBuilder);
            //Console.WriteLine();
            //stringBuilder.Replace('-', '+'); // Replaces the '-' with a '+'.
            //Console.WriteLine(stringBuilder);
            //Console.WriteLine();
            //stringBuilder.Remove(0, 10); // Removes 10 characters starting from index 0.
            //Console.WriteLine(stringBuilder);
            //Console.WriteLine();
            //stringBuilder.Insert(0, new string('=', 10)); // Inserts "==========" at the beginning of the StringBuilder.
            //Console.WriteLine(stringBuilder);
            //Console.WriteLine();
            //Console.WriteLine(stringBuilder[0]); // First character of the StringBuilder.

            Exercises.ExerciseFive();
        }
    }
}
