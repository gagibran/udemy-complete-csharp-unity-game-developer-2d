using System;
using System.Collections.Generic;

namespace WorkingWithText
{
    public class Exercises
    {
        public static void ExerciseOne()
        {
            Console.WriteLine("Enter a few numbers separated by comma, like 1,4,2,5,...:");
            var input = Console.ReadLine();
            string[] numbersText = input.Split(',');
            var isConsecutive = true;
            for (int i = 0; i < numbersText.Length - 1; i++)
            {
                var number = Convert.ToInt32(numbersText[i]);
                var nextNumber = Convert.ToInt32(numbersText[i + 1]);
                if (number + 1 != nextNumber)
                {
                    isConsecutive = false;
                    break;
                }
            }
            if (!isConsecutive)
            {
                for (int i = numbersText.Length - 1; i > 1; i--)
                {
                    var number = Convert.ToInt32(numbersText[i]);
                    var previousNumber = Convert.ToInt32(numbersText[i - 1]);
                    if (number + 1 != previousNumber)
                    {
                        isConsecutive = false;
                        break;
                    }
                    else
                    {
                        isConsecutive = true;
                    }
                }
            }
            if (isConsecutive)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
        }
        public static void ExerciseTwo()
        {
            Console.WriteLine("Enter a few numbers separated by comma, like 1,4,2,5,... Press Enter to exit.");
            var input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
            {
                return;
            }
            string[] numbersText = input.Split(',');
            var numbers = new List<int>();
            var isDuplicate = false;
            foreach (var numberText in numbersText)
            {
                numbers.Add(Convert.ToInt32(numberText));
            }
            numbers.Sort();
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (isDuplicate)
            {
                Console.WriteLine("Duplicate");
            }
        }
        public static void ExerciseThree()
        {
            Console.WriteLine("Enter a time value in the 24 h format. Example: 19:00.");
            var input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }
            string[] hourAndMinuteText = input.Split(':');
            var hours = Convert.ToInt32(hourAndMinuteText[0]);
            var minutes = Convert.ToInt32(hourAndMinuteText[1]);
            if (hours < 0 || hours > 23 || minutes < 0 || minutes > 59 || input.Length < 5)
            {
                Console.WriteLine("Invalid Time");
                return;
            }
            Console.WriteLine("OK");
        }
        public static void ExerciseFour()
        {
            Console.WriteLine("Write some words separated by space:");
            var input = Console.ReadLine();
            var output = "";
            foreach (var word in input.Split(' '))
            {
                output += word.ToUpper()[0] + word.ToLower().Substring(1);
            }
            Console.WriteLine(output);
        }
        public static void ExerciseFive()
        {
            Console.WriteLine("Enter an English word:");
            var input = Console.ReadLine().ToLower();
            int count = 0;
            foreach (var character in input)
            {
                if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
