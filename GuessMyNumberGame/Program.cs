using System;

namespace GuessMyNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro.IntroEx();
            Intro.IntroPartOne();

            int[] initialList = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Console.WriteLine();
            int inputNumber = 0;

            while (inputNumber == 0)
            {
                inputNumber = PartOne.captureInput();
            }

            PartOne.BisectionSearch(inputNumber, initialList);

        }
    }
}
