using System;

namespace GuessMyNumberGame
{
    public class PartThree
    {
        public static void GuessMyNumRobot(int myNumber)
        {
            int min = 1;
            int max = 101;
            int attempts = 0;
            int roboNumber = Program.RandomNumber.Next(1, 101);

            while (true)
            {
                if (roboNumber > myNumber)
                {
                    max = roboNumber;
                    attempts++;
                    Console.WriteLine($"\n\n\tComputer's Number: {roboNumber}.");
                    Console.WriteLine($"\tToo high! Attempt number {attempts}.");
                    roboNumber = Program.RandomNumber.Next(min, max);
                    Console.Write("\tPress any key to continue..");
                    Console.ReadKey();
                }

                else if (roboNumber < myNumber)
                {
                    min = roboNumber + 1;
                    attempts++;
                    Console.WriteLine($"\n\n\tComputer's Number: {roboNumber}.");
                    Console.WriteLine($"\tToo low! Attempt number {attempts}.");
                    roboNumber = Program.RandomNumber.Next(min, max);
                    Console.Write("\tPress any key to continue..");
                    Console.ReadKey();
                }

                else if (roboNumber == myNumber)
                {
                    attempts++;
                    Console.WriteLine($"\n\n\tComputer's Number: {roboNumber}.");
                    Console.WriteLine($"\tComputer wins! Total attempts: {attempts}.");
                    break;
                }
            }
        }
    }
}