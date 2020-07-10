using System;

namespace Strategy
{
    class BubbleSort : IStrategy
    {
        public int[] Sort(int[] input)
        {
            System.Console.WriteLine("Commencing bubble sort");
            for (int i = 0; i <= input.Length - 2; i++)
                {
                    for (int j = 0; j <= input.Length - 2; j++)
                    {
                        if (input[j] > input[j + 1])
                        {
                            int Temp = input[j];
                            input[j] = input[j + 1];
                            input[j + 1] = Temp;
                        }
                    }
                }
            return input;
        }
    }
}