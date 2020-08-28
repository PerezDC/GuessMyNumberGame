using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace GuessMyNumberGame
{
    class PartOne
    {
        public static int captureInput(int max)
        {
            int usersNumber = 0;

            try
            {
                Console.Write($"\n\tEnter a number ranging from 1 and {max}: ");
                usersNumber = Int32.Parse(Console.ReadLine());

                while (usersNumber == 0 || usersNumber > max)
                {
                    Console.WriteLine($"\n\n\tYou entered {usersNumber}.");
                    Console.Write($"\tTry again - Number must be within 1 and {max}.");
                    usersNumber = Int32.Parse(Console.ReadLine());
                }
            }

            catch (FormatException fe)
            {
                Console.Write("\n\tInvalid format.");
                usersNumber = 0;
            }

            return usersNumber;

        }

        public static void BisectionSearch(int usersValue, int[] list)
        {
            while (list.Length != 1)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if (usersValue == list[i])
                    {
                        if (list[i] >= list[list.Length / 2])
                        {

                            int middleNum = 0;
                            int[] tempList = new int[0];

                            if ((list.Length == 5 && usersValue == 5) || (list.Length == 5 && usersValue == 10))
                            {
                                middleNum = list[list.Length / 2];
                                Console.WriteLine($"\n\tThe middle value is {middleNum}.");
                                tempList = new int[2];
                                int j = 3;

                                for (int ii = 0; ii < 2; ii++)
                                {
                                    tempList[ii] = list[j];
                                    j++;
                                }

                            }

                            else
                            {

                                middleNum = list[list.Length / 2];

                                Console.WriteLine($"\n\tThe middle value is {middleNum}.");

                                tempList = new int[list.Length / 2];

                                int j = list.Length / 2;

                                for (int ii = 0; ii < list.Length / 2; ii++)
                                {
                                    tempList[ii] = list[j];
                                    j++;
                                }

                            }

                            list = tempList;

                            Console.WriteLine($"\n\tThe number {usersValue} is above the middle number; new list is:");
                            Console.WriteLine("\t({0})", String.Join(", ", list));
                        }

                        else if (list[i] <= list[list.Length / 2])
                        {
                            int middleNum = list[list.Length / 2];

                            Console.WriteLine($"\n\tThe middle value is {middleNum}.");

                            int[] tempList = new int[list.Length / 2];

                            int j = list.Length / 2;

                            for (int ii = 0; ii < list.Length / 2; ii++)
                            {
                                tempList[ii] = list[ii];
                            }

                            list = tempList;

                            Console.WriteLine($"\n\tThe number {usersValue} is below the middle number, new list is:");
                            Console.WriteLine("\t({0})", String.Join(", ", list));
                        }

                    }
                }
            }
            Console.WriteLine($"\n\tThe value searched for, {list[0]}, has been found. ");
        }

    }
}
