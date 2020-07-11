using System;

namespace Command
{
    public class DVDPlayCommand : ICommand
    {
        public DVDPlayCommand()
        {
        }
        public void Execute()
        {
            Console.WriteLine("DVD Started.");
        }
    }
}