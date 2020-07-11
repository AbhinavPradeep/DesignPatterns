using System;

namespace Command
{
    using System;
    public class DVDStopCommand : ICommand
    {
        public DVDStopCommand()
        {
        }
        public void Execute()
        {
            Console.WriteLine("DVD Stopped.");
        }
    }
}