using System;

namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Gabriel Gibran ";
            Console.WriteLine("Trim '{0}'", fullName.Trim()); // Removes whitespace on the beginning and at the end.
            Console.WriteLine("ToUpper '{0}'", fullName.ToUpper());
            Console.WriteLine("ToLower '{0}'", fullName.ToLower());
            Console.WriteLine("IndexOf '{0}'", fullName.ToLower());

            // Creating a substring:
            var index = fullName.IndexOf(' '); // Returns the first instance of a whitespace.
            var firstName = fullName.Substring(0, index); // Creates a substring from the 0th position until the first whitespace. In other words: the first name.
            var lastName = fullName.Substring(index + 1).Trim(); // Creates a substring from after the whitespace until the end. In other words: the last name.

            // Creating a substring from Split():
            Console.WriteLine(fullName.Split(' ')[1]); // Split() returns an array.

            // Replace:
            Console.WriteLine(fullName.Replace("Gabriel", "Gab"));

            // Null strings:
            if (String.IsNullOrEmpty(" ")) // Works for null or "".
            {
                Console.WriteLine("The string is empty or null.");
            }

            // To detect an empty string with whitespaces we can either do a trim, or use the better and newer method:
            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("The string is empty, null, or filled with whitespaces.");
            }

            // Using format strings:
            double price = 12.45;
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C0")); // Gets rid of the decimal points.
        }
    }
}
