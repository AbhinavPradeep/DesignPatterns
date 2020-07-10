using System;

namespace Strategy
{
    class InsertionSort : IStrategy
    {
        public int[] Sort(int[] input)
        {
            System.Console.WriteLine("Commencing insertion sort");
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (input[j - 1] > input[j])
                    {
                        int TemporaryVariable = input[j];
                        input[j] = input[j - 1];
                        input[j - 1] = TemporaryVariable;
                    }
                }
            }
            return input;
        }
    }
}