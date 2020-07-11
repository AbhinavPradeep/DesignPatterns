using System;

namespace Command
{
    public class VCRStopCommand : ICommand
    {
        public VCRStopCommand()
        {
        }
        public void Execute()
        {
            Console.WriteLine("VCR Stopped.");
        }
    }

}