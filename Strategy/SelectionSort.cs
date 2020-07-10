using System;

namespace Strategy
{
    class SelectionSort : IStrategy
    {
        public int[] Sort(int[] input)
        {
            int smallestIndex;
            for (int i = 0; i < input.Length - 1; i++)
            {
                System.Console.WriteLine("Commencing selection sort");
                smallestIndex = i;
                for (int currentIndex = i + 1; currentIndex < input.Length; currentIndex++)
                {
                    if (input[currentIndex] < input[smallestIndex])
                    {
                        smallestIndex = currentIndex;
                    }
                }
                int TemporaryVariable = input[i];
                input[i] = input[smallestIndex];
                input[smallestIndex] = TemporaryVariable;
            }
            return input;
        }
    }
}
