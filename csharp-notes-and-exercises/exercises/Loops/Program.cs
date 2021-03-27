using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciseFive();
        }
        static void ExerciseTwo()
        {
            double sum = 0;
            while (true)
            {
                string userInput = Console.ReadLine();
                if (userInput.ToLower().Equals("ok"))
                {
                    Console.WriteLine(sum);
                    break;
                }
                sum += double.Parse(userInput);
            }
        }
        static void ExerciseThree()
        {
            int randomInt = new Random().Next(1, 11);
            Console.WriteLine("Guess a number between 1 to 10. You have 4 tries:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(string.Format("Try {0}: ", i + 1));
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == randomInt)
                {
                    Console.WriteLine("You won! The number was {0}", randomInt);
                    return;
                }
            }
            Console.WriteLine("You lost. The number was {0}.", randomInt);
        }
        static void ExerciseFive()
        {
            Console.WriteLine("Enter numbers separated by comma:");
            string[] numbersStr = Console.ReadLine().Split(",");
            int currentMax = int.MinValue;
            foreach (string numberStr in numbersStr)
            {
                int number = int.Parse(numberStr);
                if (number > currentMax)
                {
                    currentMax = number;
                }
            }
            Console.WriteLine("Max number: {0}.", currentMax);
        }
    }
}
