using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread[] ArrayOfThreads = new Thread[15];
            for (int i = 0; i < 15; i++)
            {
                Thread thread = new Thread(() =>
                {
                    SomeExpensiveResource someExpensiveResource = SomeExpensiveResource.Instance;
                    someExpensiveResource.UseExpensiveResource();
                });
                ArrayOfThreads[i] = thread;
            }
            for (int i = 0; i < 15; i++)
            {
                ArrayOfThreads[i].Start();
            }
        }
    }
}
