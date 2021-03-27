using System.IO;
using System.Text.RegularExpressions;

namespace WorkingWithFiles
{
    class Exercises
    {
        private static string[] CleanAndSplitText(string path)
        {
            string text = File.ReadAllText(path);
            text = Regex.Replace(text, @"[^A-Za-z0-9 ]", " "); // Matches any non-word character that's not a whitespace nor a number.
            text = Regex.Replace(text, @" {2,}", " "); // If there are two or more whitespace replaces it with only one.
            return text.Trim().Split();

        }
        public static int ExerciseOne(string path)
        {
            return CleanAndSplitText(path).Length;
        }
        public static string ExerciseTwo(string path)
        {
            string[] words = CleanAndSplitText(path);
            int currentLongestLength = 0;
            string longestWord = "";
            foreach (var word in words)
            {
                if (word.Length > currentLongestLength)
                {
                    currentLongestLength = word.Length;
                    longestWord = word;
                }
            }
            return longestWord;
        }
    }
}
