using System;

namespace GuessMyNumberGame
{
    class Program
    {

        public static Random RandomNumber = new Random();

        static void Main(string[] args)
        {
            Intro.IntroEx();
            Intro.IntroPartOne();

            int[] initialList = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int inputNumber = 0;

            while (inputNumber == 0)
            {
                inputNumber = PartOne.captureInput(10);
            }
            PartOne.BisectionSearch(inputNumber, initialList);

            Intro.IntroPartTwo();
            PartTwo.GuessMyNumberHumanPlay();

            Intro.IntroPartThree();
            inputNumber = 0;
            while (inputNumber == 0)
            {
                inputNumber = PartOne.captureInput(100);
            }
            PartThree.GuessMyNumRobot(inputNumber);
            
        }
    }
}
