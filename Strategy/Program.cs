using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Input = new int[] {1,-4,3,2,5,3,6,3,6,0};
            Context StrategyA = new Context(new BubbleSort());
            var Result = StrategyA.ExecuteStrategy(Input);
            PrintArray Printer = new PrintArray();
            Printer.PrintIntegerArray(Result);
        }
    }
}
