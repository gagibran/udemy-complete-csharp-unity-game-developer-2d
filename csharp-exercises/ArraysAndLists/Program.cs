using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciseFive();
        }

        // Exercise 1:
        static void ExerciseOne()
        {
            List<string> names = new List<string>();
            Console.WriteLine("Write some names:");
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }
                names.Add(name);
            }
            if (names.Count == 1)
            {
                Console.WriteLine(String.Format("{0} liked your post.", names[0]));
            }
            else if (names.Count == 2)
            {
                Console.WriteLine(String.Format("{0} and {1} liked your post.", names[0], names[1]));
            }
            else if (names.Count > 2)
            {
                Console.WriteLine(String.Format("{0}, {1}, and {2} more people liked your post.", names[0], names[1], names.Count - 2));
            }
        }

        // Exercise 2:
        static void ExerciseTwo()
        {
            Console.WriteLine("Write your name:");
            var name = Console.ReadLine();
            var nameArray = new char[name.Length];
            for (int i = nameArray.Length - 1; i >= 0; i--)
            {
                nameArray[i] = name[nameArray.Length - 1 - i];
            }
            Console.WriteLine(string.Join("", nameArray));
        }

        // Exercise 3:
        static void ExerciseThree()
        {
            var numbers = new List<int>();
            Console.WriteLine("Enter five numbers:");
            while (numbers.Count < 5)
            {
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("Error: Duplicate number. Re-enter a valid number:");
                    continue;
                }
                numbers.Add(number);
            }
            numbers.Sort();
            Console.WriteLine("The sorted numbers are:");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }

        // Exercise 4:
        static void ExerciseFour()
        {
            Console.WriteLine("Enter some numbers. Type \"Quit\" to finish:");
            var numbers = new List<int>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input.Equals("Quit"))
                {
                    break;
                }
                var number = int.Parse(input);
                if (numbers.Contains(number))
                {
                    continue;
                }
                numbers.Add(number);
            }
            Console.WriteLine("The unique numbers you entered are:");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }

        // Exercise 5:
        static void ExerciseFive()
        {
            var numbers = new List<int>();
            string[] numbersStr;
            Console.WriteLine("Enter numbers separated by comma:");
            while (true)
            {
                var numbersSepComma = Console.ReadLine();
                numbersStr = numbersSepComma.Split(",");
                if (numbersStr.Length < 5)
                {
                    Console.WriteLine("Invalid list. Try again.");
                    continue;
                }
                break;
            }
            for (int i = 0; i < numbersStr.Length; i++)
            {
                numbers.Add(Convert.ToInt32(numbersStr[i]));
            }
            var minValues = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                var currentMin = int.MaxValue;
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (currentMin > numbers[j])
                    {
                        currentMin = numbers[j];
                    }
                }
                minValues.Add(currentMin);
                numbers.Remove(currentMin);
            }
            Console.WriteLine("The smallest 3 numbers are:");
            foreach (var minValue in minValues)
            {
                Console.WriteLine(minValue);
            }

            // Or, my way, which is using the built-in Sort() method, which is better:
            //numbers.Sort();
            //Console.WriteLine(string.Format("The smallest 3 numbers are: {0}, {1}, and {2}.", numbers[0], numbers[1], numbers[2]));
        }
    }
}
