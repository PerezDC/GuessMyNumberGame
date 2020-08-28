using System;

namespace GuessMyNumberGame
{
    public class PartTwo
    {
        public static void GuessMyNumberHumanPlay()
        {
            Console.WriteLine("\n\tI'm going to pick a number ranging from 1 to 1000.");
            Console.WriteLine("\tIt's your job to guess the number.");
            Console.WriteLine("\tI'll let you know if you're guessing too high or too low.");

            int myNumber = Program.RandomNumber.Next(1,1001);
            int attempts = 0;
            bool stopLoop = false;

            while (stopLoop == false)
            {
                Console.Write("\n\tEnter your guess: ");
                int userInput = Int32.Parse(Console.ReadLine());

                if (userInput == myNumber)
                {
                    attempts++;
                    Console.WriteLine($"\tYou got me! My number was {myNumber}. Total attempts: {attempts}.");
                    stopLoop = true;
                }

                if (userInput > myNumber)
                {
                    Console.WriteLine("\tToo high! Try again.");
                    attempts++;
                    Console.WriteLine($"\tAttempt number {attempts}.");
                }

                if (userInput < myNumber)
                {
                    Console.WriteLine("\tToo low! Try again.");
                    attempts++;
                    Console.WriteLine($"\tAttempt number {attempts}.");
                }
            }

        }
    }
}